using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMGemeenschap
{
    [Table("Personen")]
    public class Persoon
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }
        [Required, Column("Categorie")]
        public Categorie Categorie { get; set; }
        public string Aanspreking { get; set; }
        [Required]
        public string Voornaam { get; set; }
        [Required]
        public string Familienaam { get; set; }
        [Column("Bedrijf")]
        public Bedrijf Bedrijf { get; set; }
        public string Adres { get; set; }
        public string Postcode { get; set; }
        public string Gemeente { get; set; }
        public string Land { get; set; }
        public string Telefoon { get; set; }
        public string Email { get; set; }
    }
}
