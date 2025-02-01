using System.ComponentModel.DataAnnotations;

namespace eticaretim.Models
{
    public class Urunler
    {
        [Key]
        public int UrunId { get; set; }
        public string UrunAd { get; set; } = string.Empty;
        public int ? Fiyat { get; set; }
        public int ? Indirim { get; set; }
        public string Detay { get; set; } = string.Empty;
        public string Aciklama { get; set; } = string.Empty;
        public int ? Stok { get; set; }
        public string Marka { get; set; } = string.Empty;
        public  int ? Aktif { get; set; }
        public int ? Slayt { get; set; }
        public int ? KategoriId { get; set; }   
        public virtual Kategoriler ? Kategoriler { get; set; }

    }
}
