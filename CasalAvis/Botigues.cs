using System.ComponentModel.DataAnnotations;

namespace CasalAvis
{
    public class Botigues
    {
        [Key]
        public int IdBotiga { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string? NomBotiga { get; set; }
    }
}
