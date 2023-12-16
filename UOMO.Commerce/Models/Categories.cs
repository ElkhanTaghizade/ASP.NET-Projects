using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Models
{
    public class Categories
    {
        [Key] public int Id { get; set; }
        [Required] [StringLength(50)]public string Name { get; set; }
        public virtual List<Products> Products { get; set; }

    }
}
