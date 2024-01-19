namespace Ass_NET105.Models
{
    public class SanPham
    {
        public Guid IdSP { get; set; }
        public string TenSP { get; set; }
        public virtual IEnumerable<SanPhamCT> SanPhamCT { get; set; }
    }
}
