using Cars.Models.Base;
using Cars.Models.Cars;

namespace Cars.Models
{
    public class City:BaseEntity
    {
        public string? CityName { get; set; }
        public List<Vehicles>? Vehicles { get; set; }
     
    }
}
