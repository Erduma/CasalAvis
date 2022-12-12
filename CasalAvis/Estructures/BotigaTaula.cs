using System.ComponentModel.DataAnnotations;

namespace CasalAvis.Estructures
{
    public class BotigaTaula
    {
        [Key]
        public int IdBotiga { get; set; }
        public string? NomBotiga { get; set; }
        public string? NomBarri { get; set; }
        public string? NomCarrer { get; set; }

    }
}
