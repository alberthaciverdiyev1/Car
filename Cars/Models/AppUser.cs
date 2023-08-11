using Cars.Models.Cars;
using Microsoft.AspNetCore.Identity;

namespace Cars.Models
{
    public class AppUser:IdentityUser
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public byte? Age { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? ProfileImageURL { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public List<Vehicles>? Vehicles { get; set; }
    }
}
