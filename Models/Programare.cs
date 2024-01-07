using System.ComponentModel.DataAnnotations;

namespace Proiect_Farcas_Gherghelas.Models
{
    public class Programare
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Data si ora")]
        public DateTime DataOra { get; set; }

        [Required]
        [Display(Name = "Numar ore inchiriate")]
        public int NrOre { get; set; }

        public int? ProdusID { get; set; }
        public Produs? Produs { get; set; }

        public int? UserID { get; set; }
        public User? User { get; set; }

        [Display(Name = "MagazinID")]
        public int? InchiriereID { get; set; }
        public Inchiriere? Inchiriere { get; set; }
    }
}
