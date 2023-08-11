using Cars.Models.Base;

namespace Cars.Models.Cars
{
    public class Marka:BaseEntity
    {
        public string? MarkaName { get; set; }
        public string? Description { get; set; }
        public string? ImageURL { get; set; }
        public List<Model>?Models { get; set; }
    }
}
