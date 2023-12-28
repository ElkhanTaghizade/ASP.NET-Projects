using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication5.Models
{
    public class Slider
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CollectionName { get; set; }
        [Required]
        public string Title { get; set; }
        [ValidateNever]
        public string Description { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [NotMapped]
        [Required]
        public IFormFile File { get; set; } 

    }
}
