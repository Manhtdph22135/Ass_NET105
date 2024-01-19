using System.ComponentModel.DataAnnotations;

namespace Ass_NET105.Models
{
    public class HangSX
    {
        [Key]
        public Guid IDHangSx { get; set; }
        public string TenHangSX { get; set; }

        public virtual IEnumerable<SanPhamCT> SanPhamCT { get; set; }
    }
}
