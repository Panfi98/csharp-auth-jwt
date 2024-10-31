using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.wwwapi.Model
{
    [Table("Order")]
    public class Order
    {
        [Key]
        [Column("OrderID")]
        public int OrderID { get; set; }

        [Column("Created At")]
        public string CreatedAt { get; set; }

        [Column("CustomerID")]
    }
}
