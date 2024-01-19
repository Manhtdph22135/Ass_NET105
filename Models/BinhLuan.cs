using System.ComponentModel.DataAnnotations;

namespace Ass_NET105.Models
{
    public class BinhLuan
    {
        [Key]
        public Guid IDBinhLuan { get; set; }
        public Guid IDSPCT { get; set; }
        public Guid IDNguoiDung { get; set; }
        public string NoiDung { get; set; }
        public DateTime NgayBinh { get; set; }

        public virtual SanPhamCT SanPhamCT { get; set; }
        public virtual NguoiDung NguoiDung { get; set; }
    }
}
