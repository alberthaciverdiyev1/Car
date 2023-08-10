using Cars.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace Cars.ViewModels
{
    public class RegisterVM:BaseEntity
    {
        [Required]
        [MinLength(3,ErrorMessage ="Name is short")]
        [MaxLength(30,ErrorMessage ="Name is long")]
        public string? Name { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Name is short")]
        [MaxLength(30, ErrorMessage = "Name is long")]
        public string? Surname { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Name is short")]
        [MaxLength(30, ErrorMessage = "Name is long")] 
        public string? UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string? ConfirmPassword { get; set; }
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public bool RememberMe { get; set; }
        public string? ProfileImageURL { get; set; }
        public IFormFile? Photo { get; set; }

    }
}
