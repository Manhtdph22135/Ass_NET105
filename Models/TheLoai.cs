using System.ComponentModel.DataAnnotations;

namespace Ass_NET105.Models
{
    public class TheLoai
    {
        [Key]
        public Guid IDTheLoai { get; set; }
        public string TenTheLoai { get; set; }
        public string MoTa { get; set; }
        public virtual IEnumerable<SanPhamCT> SanPhamct { get; set; }
    }
}
