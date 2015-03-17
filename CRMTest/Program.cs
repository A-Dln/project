using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMGemeenschap;

namespace CRMTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //iets toegevoegd om fetch en pull te testen
            //nog een toevoeging
            //en nog eentje om te testen...
            using (var context = new CRMContext())
            {
                Categorie categorie = new Categorie { Code = "JJJ", Omschrijving = "Blabla" };
                var bedrijf = new Bedrijf { Id = "B024", Naam = "Bedrijf 4", Categorie = categorie };
                context.Bedrijven.Add(bedrijf);
                context.SaveChanges();
                KlantManager mgr = new KlantManager();
                List<Bedrijf> gevondenbedrijven = mgr.ZoekBedrijfOpCategorie(categorie);
                foreach (var bedr in gevondenbedrijven)
                    Console.WriteLine(bedr.Naam);
            }
        }
    }
}
