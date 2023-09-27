using System.ComponentModel.DataAnnotations;

namespace Logistics.Models
{
    public class Customer : BaseEntity
    {
        [StringLength(1000)]
        public string Image { get; set; }
    }
}
