using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetSeries.Models
{
    public class Anime
    {
        [Key]
        public int AnimeId { get; set; }
        [Required]
        public string AnimeName { get; set; }
        public string AnimeDescription { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }
        public string ImageUrl { get; set; }

    }
}



