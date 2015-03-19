using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CRMGemeenschap;
using System.Collections.ObjectModel;

namespace CRMWpf
{
    /// <summary>
    /// Interaction logic for BeheerProducten.xaml
    /// </summary>
    public partial class BeheerProducten : Window
    {
        private CRMContext context = new CRMContext();
        public ObservableCollection<Product> productenOb = new ObservableCollection<Product>();

        public BeheerProducten()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            VulListBox();
        }

        /// <summary>
        /// Categorieën in de database ophalen en deze in de ListBox plaatsen
        /// </summary>
        private void VulListBox()
        {
            productenOb.Clear();
            var query = from product in context.Producten
                        orderby product.Id
                        select product;
            foreach (var product in query)
            {
                productenOb.Add(product);
            }
            listBoxProducten.ItemsSource = productenOb;
        }

        public void ZoekProducten(string zoekterm)
        {
            labelFeedback.Content = "Zoeken...";
            List<Product> gevondenProducten = new List<Product>();
            var query = from product in context.Producten
                        where product.Id.Contains(zoekterm) || product.Omschrijving.Contains(zoekterm)
                        select product;
            foreach (var product in query)
            {
                gevondenProducten.Add(product);
            }
            listBoxProducten.ItemsSource = gevondenProducten;
            labelFeedback.Content = new StringBuilder(gevondenProducten.Count + " producten gevonden. Druk op de knop \"Alles\" om alle producten te zien");
        }

        private void ZoekButton_Click(object sender, RoutedEventArgs e)
        {
            ZoekProducten(textBoxZoeken.Text);
        }

        private void AllesButton_Click(object sender, RoutedEventArgs e)
        {
            VulListBox();
            textBoxZoeken.Text = string.Empty;
            labelFeedback.Content = string.Empty;
        }

        private void buttonVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            Product selectie = listBoxProducten.SelectedItem as Product;
            if (selectie != null)
            {
                var zoekProduct = context.Producten.Find(selectie.Id);
                if (zoekProduct != null)
                {
                    context.Producten.Remove(zoekProduct);
                    context.SaveChanges();
                }
                else
                {
                    labelFeedback.Content = "Er is geen product met deze omschrijving";
                }
            }
            else
            {
                labelFeedback.Content = "Selecteer eerst een item uit de lijst";
            }
            VulListBox();
        }

        private void buttonWijzigen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonToevoegen_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
