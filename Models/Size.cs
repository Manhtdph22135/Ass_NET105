using System.ComponentModel.DataAnnotations;

namespace Ass_NET105.Models
{
    public class Size
    {
        [Key]
        public Guid IDSize { get; set; }
        public decimal SizeGiay { get; set; }
        public virtual IEnumerable<SanPhamCT> SanPhamct { get; set; }
    }
}
