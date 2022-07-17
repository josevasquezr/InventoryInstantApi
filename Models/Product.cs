using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }

        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int TotalQuantity { get; set; }

    }
}
