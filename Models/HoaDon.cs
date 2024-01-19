using System.ComponentModel.DataAnnotations;

namespace Ass_NET105.Models
{
    public class HoaDon
    {
        [Key]
        public Guid IdBill { get; set; }
        public Guid IDKhachHang { get; set; }
        public Guid IDVoucher { get; set; }
        public string MaHD { get; set; }
        public int SoLuong { get; set; }
        public decimal ThanhTien { get; set; }
        public decimal TongThanhToan { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayNhan { get; set; }
        public DateTime NgayShip { get; set; }
        public string TenNguoiNhan { get; set; }
        public string SDTNguoiNhan { get; set; }
        public string DiaChiNguoiNhan { get; set; }
        public int TrangThai { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }

        public virtual IEnumerable<HoaDonCT> HoaDonCTs { get; set; }
    }
}
