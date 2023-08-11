using Cars.Models.Base;

namespace Cars.Models.Cars
{
    public class VehicleImages:BaseEntity
    {
        public string? ImageUrl { get; set; }
        public List<Vehicles>? Vehicles { get; set; }
    }
}
