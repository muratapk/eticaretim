
using System.ComponentModel.DataAnnotations;

namespace eticaretim.Models
{
    public class Kategoriler
    {
        [Key]
        public int KategoriId { get; set; }
        public string KategoriAd { get; set; } = string.Empty;
        public virtual List<Urunler>? Urunsler { get; set; }
    }
}
