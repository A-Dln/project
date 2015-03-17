using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMGemeenschap
{
    [Table("Bedrijven")]
    public class Bedrijf
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }
        [Required, Column("Categorie")]
        public Categorie Categorie { get; set; }
        [Required]
        public string Naam { get; set; }
        public string Adres { get; set; }
        public string Postcode { get; set; }
        public string Gemeente { get; set; }
        public string Land { get; set; }
        public string Telefoon { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
    }
}
