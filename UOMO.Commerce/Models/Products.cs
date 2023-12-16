using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication5.Models
{
    public class Products
    {
        [Key] public int Id { get; set; }
        [Required] public string Name { get; set; }
        [Required] public float Price { get; set; }
        [NotMapped] public string Test {  get; set; }
        public int CategoriesId {  get; set; }
        [ForeignKey("CategoriesId")]
        public virtual Categories Categories { get; set; }





    }
}
