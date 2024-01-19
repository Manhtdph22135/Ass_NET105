using System.ComponentModel.DataAnnotations;

namespace Ass_NET105.Models
{
    public class HoaDonCT
    {
        [Key]
        public Guid IDHDCT { get; set; }
        public Guid IDHD { get; set; }
        public Guid IDSPCT { get; set; }
        public decimal Gia { get; set; }
        public int SoLuong { get; set; }

        public virtual HoaDon HoaDon { get; set; }
        public virtual SanPhamCT SanPhamct { get; set; }
    }
}
