using System.ComponentModel.DataAnnotations;

namespace Ass_NET105.Models
{
    public class ChucVu
    {
        [Key]
        public Guid IDRole { get; set; }
        public string TenChucVu { get; set; }
        public string MoTa { get; set; }
        public int TrangThai { get; set; }

        public virtual IEnumerable<NguoiDung> NguoiDung { get; set; }
    }
}
