using System.ComponentModel.DataAnnotations;

namespace Ass_NET105.Models
{
    public class MauSac
    {
        [Key]
        public Guid IDMau { get; set; }
        public string Mausac { get; set; }
        public virtual IEnumerable<SanPhamCT> SanPhamct { get; set; }
    }
}
