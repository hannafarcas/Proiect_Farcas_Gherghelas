using System.ComponentModel.DataAnnotations;

namespace Proiect_Farcas_Gherghelas.Models
{
    public class User
    {
        public int ID { get; set; }

        [RegularExpression(@"^[A-Z]+[a-z\s]*$")]
        [StringLength(30, MinimumLength = 3)]
        public string? Nume { get; set; }

        [RegularExpression(@"^[A-Z]+[a-z\s]*$")]
        [StringLength(30, MinimumLength = 3)]
        public string? Prenume { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public string? Telefon { get; set; }

        [Display(Name = "Nume Complet")]
        public string? NumeComplet
        {
            get
            {
                return Prenume + " " + Nume;
            }
        }

         public ICollection<Programare>? Programari { get; set; }

    }
}
