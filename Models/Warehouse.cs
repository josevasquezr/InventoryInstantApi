using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Warehouse
    {
        [Key]
        public Guid WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public string WarehouseAddress { get; set; }
    }
}
