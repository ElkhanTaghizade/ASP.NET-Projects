using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace WebApplication5.Models
{
    public class Products
    {
        [Key] public int Id { get; set; }
        [Required] public required string Name { get; set; }
        [Required] public float Price { get; set; }
        [ValidateNever]
        public required string ImageUrl { get; set; }
        [Required]
        public required string Context {  get; set; }
        [Required]
        public int CategoriesId { get; set; }
        [ForeignKey("CategoriesId")]
        [ValidateNever]
        public virtual required Categories Categories { get; set; }
        [NotMapped]
        [Required]
        public required IFormFile File { get; set; }





    }
}
