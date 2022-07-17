using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Storage
    {
        [Key]
        public Guid StorageId { get; set; }

        [ForeignKey("Product")]
        public Guid ProductId { get; set; }

        [ForeignKey("Warehouse")]
        public Guid WarehouseId { get; set; }
        public DateTime LastUpdate { get; set; }
        public int PartialQuantity { get; set; }
    }
}
