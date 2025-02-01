using System.ComponentModel.DataAnnotations;

namespace eticaretim.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string UserPassword { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
    }
}
