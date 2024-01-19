using System.ComponentModel.DataAnnotations;

namespace Ass_NET105.Models
{
    public class GioHangCT
    {
        [Key]
        public Guid IDGHCT { get; set; }
        public Guid IDGH { get; set; }
        public Guid IDSPCT { get; set; }
        public decimal Gia { get; set; }
        public int SoLuong { get; set; }

        public virtual GioHang GioHang { get; set; }
        public virtual SanPhamCT SanPhamCT { get; set; }
    }
}
