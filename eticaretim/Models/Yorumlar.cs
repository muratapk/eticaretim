using System.ComponentModel.DataAnnotations;

namespace eticaretim.Models
{
    public class Yorumlar
    {
        [Key]
        public int YorumId { get; set; }
        public string YorumAd { get; set; } = string.Empty;
        public string YorumKonu { get; set; } = string.Empty;
        public int ? UrunId { get; set; }
    }
}
