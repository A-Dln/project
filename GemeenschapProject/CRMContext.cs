using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMGemeenschap
{
    public class CRMContext : DbContext
    {
        public DbSet<Categorie> Categorieen { get; set; }
        public DbSet<Bedrijf> Bedrijven { get; set; }
        public DbSet<Persoon> Personen { get; set; }
        public DbSet<Product> Producten { get; set; }
    }
}
