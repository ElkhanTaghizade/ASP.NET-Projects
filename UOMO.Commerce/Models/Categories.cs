using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Models
{
    public class Categories
    {
        [Key] public int Id { get; set; }
        [Required] [StringLength(50)]public required string Name { get; set; }
        public virtual required List<Products> Products { get; set; }

    }
}
