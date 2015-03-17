using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMGemeenschap
{
    [Table("Producten")]
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }
        public string Omschrijving { get; set; }
        public string Eenheid { get; set; }
        public decimal PrijsPerEenheid { get; set; }
    }
}
