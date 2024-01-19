using System.ComponentModel.DataAnnotations;

namespace Ass_NET105.Models
{
    public class GioHang
    {
        [Key]
        public Guid IDGioHang { get; set; }
        public string Description { get; set; }
        public virtual NguoiDung NguoiDung { get; set; }

        public virtual IEnumerable<GioHangCT> GioHangcts { get; set; }
    }
}
