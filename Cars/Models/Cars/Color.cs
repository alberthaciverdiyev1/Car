using Cars.Models.Base;

namespace Cars.Models.Cars
{
    public class Color:BaseEntity
    {
        public string? ColorName { get; set; }
        public List<Vehicles>? Vehicles { get; set;}
    }
}
