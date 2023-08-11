using Cars.Models.Base;

namespace Cars.Models.Cars
{
    public class Model:BaseEntity
    {
        public string? ModelName { get; set; }
        public string? ImageURL { get; set; }
        public Marka? Marka { get; set; }
        public int? MarkaId { get; set;}
    }
}
