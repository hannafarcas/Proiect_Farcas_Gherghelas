using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Proiect_Farcas_Gherghelas.Models
{
    public class Produs
    {
        public int ID { get; set; }
        [Display(Name = "Tipul Produsului")]
        public string TipProdus { get; set; }

        [Range(0, 50)]
        public int? Marime { get; set; }
        public int? Inaltime { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Pret {  get; set; }

        [Display(Name ="MagazinID")]
        public int? InchiriereID { get; set; }
        public Inchiriere? Inchiriere { get; set; }
    }
}