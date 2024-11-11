using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace OnlineShopping.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required , StringLength(50)]
        public string Name { get; set; }
        [StringLength(150)]
        public string Description { get; set; }
        [Column(TypeName ="money")]
        public decimal Price { get; set; }
        public int Amount { get; set; }
        [ForeignKey("catalog")]
        [JsonIgnore(Condition =JsonIgnoreCondition.WhenWritingNull)]
        public int? CatlId { get; set; }
        public virtual Catalog? catalog { get; set; }
        [MaybeNull]
        public string PhotoPath { get; set; }

    }
}
