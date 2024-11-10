using System.ComponentModel.DataAnnotations;

namespace OnlineShopping.Models
{
    public class Catalog
    {
        [Key]
        public int Id { get; set; }
        [Required , StringLength(50)]
        public string Name { get; set; }
        [StringLength(150)]
        public string Description { get; set; }
        public virtual List<Product> Products { get; set; } = new List<Product>();
     }
}
