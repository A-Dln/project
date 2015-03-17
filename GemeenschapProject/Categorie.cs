using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMGemeenschap
{
    [Table("Categorieën")]
    public class Categorie
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Code { get; set; }
        [Required]
        public string Omschrijving { get; set; }
    }
}
