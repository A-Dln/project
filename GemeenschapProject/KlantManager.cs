using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMGemeenschap
{
    public class KlantManager
    {
        private CRMContext context = new CRMContext();

        public List<Bedrijf> ZoekBedrijfOpCategorie(Categorie categorie)
        {
            List<Bedrijf> bedrijven = new List<Bedrijf>();
            var query = from bedrijf in context.Bedrijven
                        where bedrijf.Categorie.Equals(categorie)
                        select bedrijf;
            foreach (var bedrijf in query)
                bedrijven.Add(bedrijf);
            return bedrijven;
        }

        public List<Bedrijf> ZoekBedrijfOpNaam(string naam)
        {
            List<Bedrijf> bedrijven = new List<Bedrijf>();
            var query = from bedrijf in context.Bedrijven
                        where bedrijf.Naam.Contains(naam)
                        select bedrijf;
            foreach (var bedrijf in query)
                bedrijven.Add(bedrijf);
            return bedrijven;
        }

        public List<Bedrijf> ZoekBedrijfOpAdres(string adres)
        {
            List<Bedrijf> bedrijven = new List<Bedrijf>();
            var query = from bedrijf in context.Bedrijven
                        where bedrijf.Adres.Contains(adres)
                        select bedrijf;
            foreach (var bedrijf in query)
                bedrijven.Add(bedrijf);
            return bedrijven;
        }

        public List<Bedrijf> ZoekBedrijfOpPostcode(string postcode)
        {
            List<Bedrijf> bedrijven = new List<Bedrijf>();
            var query = from bedrijf in context.Bedrijven
                        where bedrijf.Postcode.Contains(postcode)
                        select bedrijf;
            foreach (var bedrijf in query)
                bedrijven.Add(bedrijf);
            return bedrijven;
        }

        public List<Bedrijf> ZoekBedrijfOpGemeente(string gemeente)
        {
            List<Bedrijf> bedrijven = new List<Bedrijf>();
            var query = from bedrijf in context.Bedrijven
                        where bedrijf.Gemeente.Contains(gemeente)
                        select bedrijf;
            foreach (var bedrijf in query)
                bedrijven.Add(bedrijf);
            return bedrijven;
        }

        public List<Bedrijf> ZoekBedrijfOpLand(string land)
        {
            List<Bedrijf> bedrijven = new List<Bedrijf>();
            var query = from bedrijf in context.Bedrijven
                        where bedrijf.Land.Contains(land)
                        select bedrijf;
            foreach (var bedrijf in query)
                bedrijven.Add(bedrijf);
            return bedrijven;
        }

        public List<Bedrijf> ZoekBedrijfOpTelefoon(string telefoon)
        {
            List<Bedrijf> bedrijven = new List<Bedrijf>();
            var query = from bedrijf in context.Bedrijven
                        where bedrijf.Telefoon.Contains(telefoon)
                        select bedrijf;
            foreach (var bedrijf in query)
                bedrijven.Add(bedrijf);
            return bedrijven;
        }

        public List<Bedrijf> ZoekBedrijfOpEmail(string email)
        {
            List<Bedrijf> bedrijven = new List<Bedrijf>();
            var query = from bedrijf in context.Bedrijven
                        where bedrijf.Email.Contains(email)
                        select bedrijf;
            foreach (var bedrijf in query)
                bedrijven.Add(bedrijf);
            return bedrijven;
        }

        public List<Bedrijf> ZoekBedrijfOpWebsite(string website)
        {
            List<Bedrijf> bedrijven = new List<Bedrijf>();
            var query = from bedrijf in context.Bedrijven
                        where bedrijf.Website.Contains(website)
                        select bedrijf;
            foreach (var bedrijf in query)
                bedrijven.Add(bedrijf);
            return bedrijven;
        }

        public List<Persoon> ZoekPersoonOpCategorie(Categorie categorie)
        {
            List<Persoon> personen = new List<Persoon>();
            var query = from persoon in context.Personen
                        where persoon.Categorie.Equals(categorie)
                        select persoon;
            foreach (var persoon in query)
                personen.Add(persoon);
            return personen;
        }

        public List<Persoon> ZoekPersoonOpAanspreking(string aanspreking)
        {
            List<Persoon> personen = new List<Persoon>();
            var query = from persoon in context.Personen
                        where persoon.Aanspreking.Contains(aanspreking)
                        select persoon;
            foreach (var persoon in query)
                personen.Add(persoon);
            return personen;
        }

        public List<Persoon> ZoekPersoonOpVoornaam(string voornaam)
        {
            List<Persoon> personen = new List<Persoon>();
            var query = from persoon in context.Personen
                        where persoon.Voornaam.Contains(voornaam)
                        select persoon;
            foreach (var persoon in query)
                personen.Add(persoon);
            return personen;
        }

        public List<Persoon> ZoekPersoonOpFamilienaam(string familienaam)
        {
            List<Persoon> personen = new List<Persoon>();
            var query = from persoon in context.Personen
                        where persoon.Familienaam.Contains(familienaam)
                        select persoon;
            foreach (var persoon in query)
                personen.Add(persoon);
            return personen;
        }

        public List<Persoon> ZoekPersoonOpAdres(string adres)
        {
            List<Persoon> personen = new List<Persoon>();
            var query = from persoon in context.Personen
                        where persoon.Adres.Contains(adres)
                        select persoon;
            foreach (var persoon in query)
                personen.Add(persoon);
            return personen;
        }

        public List<Persoon> ZoekPersoonOpPostcode(string postcode)
        {
            List<Persoon> personen = new List<Persoon>();
            var query = from persoon in context.Personen
                        where persoon.Postcode.Contains(postcode)
                        select persoon;
            foreach (var persoon in query)
                personen.Add(persoon);
            return personen;
        }

        public List<Persoon> ZoekPersoonOpGemeente(string gemeente)
        {
            List<Persoon> personen = new List<Persoon>();
            var query = from persoon in context.Personen
                        where persoon.Gemeente.Contains(gemeente)
                        select persoon;
            foreach (var persoon in query)
                personen.Add(persoon);
            return personen;
        }

        public List<Persoon> ZoekPersoonOpLand(string land)
        {
            List<Persoon> personen = new List<Persoon>();
            var query = from persoon in context.Personen
                        where persoon.Land.Contains(land)
                        select persoon;
            foreach (var persoon in query)
                personen.Add(persoon);
            return personen;
        }

        public List<Persoon> ZoekPersoonOpTelefoon(string telefoon)
        {
            List<Persoon> personen = new List<Persoon>();
            var query = from persoon in context.Personen
                        where persoon.Telefoon.Contains(telefoon)
                        select persoon;
            foreach (var persoon in query)
                personen.Add(persoon);
            return personen;
        }

        public List<Persoon> ZoekPersoonOpEmail(string email)
        {
            List<Persoon> personen = new List<Persoon>();
            var query = from persoon in context.Personen
                        where persoon.Email.Contains(email)
                        select persoon;
            foreach (var persoon in query)
                personen.Add(persoon);
            return personen;
        }
    }
}
