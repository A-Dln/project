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
    /// Interaction logic for BeheerCategorieen.xaml
    /// </summary>
    public partial class BeheerCategorieen : Window
    {
        private CRMContext context = new CRMContext();
        public ObservableCollection<Categorie> categorieenOb = new ObservableCollection<Categorie>();
        //!Wijzigingen van tekst op de knoppen enkel hier wijzigen
        private string modusBekijkenTekst = "Toevoegen";
        private string modusWijzigenTekst = "Annuleren";

        public BeheerCategorieen()
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
            categorieenOb.Clear();
            var query = from categorie in context.Categorieen
                        orderby categorie.Code
                        select categorie;
            foreach (var categorie in query)
            {
                categorieenOb.Add(categorie);
            }
            listBoxCategorieen.ItemsSource = categorieenOb;
        }

        private void ButtonToevoegen_Click(object sender, RoutedEventArgs e)
        {
            ToggleModus();
            textBoxCode.Text = textBoxOmschrijving.Text = string.Empty;
            listBoxCategorieen.SelectedIndex = -1;
        }

        private void buttonOpslaan_Click(object sender, RoutedEventArgs e)
        {
            //TD: controleren of alles correct ingevuld is, anders exception (niet correct ingevuld)
            if (textBoxCode.Text.Length > 5)
            {
                labelFeedBack.Content = "De code is te lang";
                return;
            }
            if (textBoxCode.Text == string.Empty || textBoxOmschrijving.Text == string.Empty)
            {
                labelFeedBack.Content = "Vul alle velden in";
                return;
            }
            Categorie categorie = new Categorie();
            categorie.Code = textBoxCode.Text;
            categorie.Omschrijving = textBoxOmschrijving.Text;
            var zoekCategorie = context.Categorieen.Find(categorie.Code);
            //als er al zo'n categorie bestaat (zoekCategorie != null), dan betreft het een wijziging
            //als zo'n categorie nog niet bestaat (zoekCategorie == null), dan betreft het een toevoeging
            if (zoekCategorie == null) 
                context.Categorieen.Add(categorie);
            context.SaveChanges();
            ToggleModus();
            textBoxCode.Text = textBoxOmschrijving.Text = string.Empty;
            VulListBox();
        }

        private void buttonVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            //als er iets geselecteerd is, deze entity verwijderen
            Categorie selectie = listBoxCategorieen.SelectedItem as Categorie;
            if (selectie != null)
            {
                var zoekCategorie = context.Categorieen.Find(selectie.Code);
                if (zoekCategorie != null)
                {
                    context.Categorieen.Remove(zoekCategorie);
                    context.SaveChanges();
                }
                else
                {
                    labelFeedBack.Content = "Er is geen categorie met deze code";
                }
            }
            else
            {
                labelFeedBack.Content = "Selecteer eerst een item uit de lijst";
            }

            VulListBox();
        }

        private void buttonWijzigen_Click(object sender, RoutedEventArgs e)
        {
            //als er iets geselecteerd is, het mogelijk maken om deze entity te wijzigen
            Categorie selectie = listBoxCategorieen.SelectedItem as Categorie;
            if (selectie != null)
            {
                ToggleModus();
            }
            else
            {
                labelFeedBack.Content = "Selecteer eerst een item uit de lijst";
            }
        }

        private void listBoxCategorieen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            labelFeedBack.Content = string.Empty;
        }

        //wijzig een aantal uiterlijkheden
        private void ToggleModus()
        {
            buttonWijzigen.IsEnabled = !buttonWijzigen.IsEnabled;
            buttonVerwijderen.IsEnabled = !buttonVerwijderen.IsEnabled;
            textBoxCode.IsReadOnly = !textBoxCode.IsReadOnly;
            textBoxOmschrijving.IsReadOnly = !textBoxOmschrijving.IsReadOnly;
            if (buttonOpslaan.Visibility == System.Windows.Visibility.Hidden)
                buttonOpslaan.Visibility = System.Windows.Visibility.Visible;
            else if (buttonOpslaan.Visibility == System.Windows.Visibility.Visible)
                buttonOpslaan.Visibility = System.Windows.Visibility.Hidden;
            if ((string)buttonToevoegen.Content == modusBekijkenTekst)
                buttonToevoegen.Content = modusWijzigenTekst;
            else if ((string)buttonToevoegen.Content == modusWijzigenTekst)
                buttonToevoegen.Content = modusBekijkenTekst;
            labelFeedBack.Content = string.Empty;
        }

        //bij sluiten window ook context "opkuisen"
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            context.Dispose();
        }
    }
}
