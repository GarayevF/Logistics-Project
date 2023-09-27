using System.ComponentModel.DataAnnotations;

namespace Logistics.Models
{
    public class Service : BaseEntity
    {
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(1000)]
        public string Image { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
    }
}
