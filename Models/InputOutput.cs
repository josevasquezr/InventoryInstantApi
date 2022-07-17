using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class InputOutput
    {
        [Key]
        public Guid InOutId { get; set; }

        [ForeignKey("Storage")]
        public Guid StorageId { get; set; }
        public DateTime InOutDate { get; set; }
        public int Quantity { get; set; }
        public bool IsInput { get; set; }
    }
}
