using System.ComponentModel.DataAnnotations;

namespace ProjetSeries.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
    }
}