using System.ComponentModel.DataAnnotations;

namespace Proiect_Farcas_Gherghelas.Models
{
    public class Inchiriere
    {
        public int ID { get; set; }

        [Required]
        public string Magazin { get; set; }

        [Required]
        public string Locatie { get; set; }
        public string Contact { get; set; }
        public int PartieID { get; set; }
        public Partie Partie { get; set; }

    }
}
