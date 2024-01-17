using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ProjetSeries.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required]
        public int name { get; set; }
    }
}
