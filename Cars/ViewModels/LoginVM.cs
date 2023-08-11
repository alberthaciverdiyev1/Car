using Cars.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace Cars.ViewModels
{
    public class LoginVM:BaseEntity
    {
        [Required]
        public string? UsernameOrEmail { get; set; }
        [Required]
        public string? Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
