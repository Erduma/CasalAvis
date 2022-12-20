using System.ComponentModel.DataAnnotations;

namespace CasalAvis.Estructures
{
    public class BotiguesMapa
    {
        [Key]
        public int IdBotiga { get; set; }
        public decimal Latitud { get; set; }
        public decimal Longitud { get; set; }
        public string? NomBotiga { get; set; }
    }
}
