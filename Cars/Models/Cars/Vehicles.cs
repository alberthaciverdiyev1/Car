using Cars.Models.Base;

namespace Cars.Models.Cars
{
    public class Vehicles : BaseEntity
    {
        public Marka? Marka { get; set; }
        public int? MarkaId { get; set; }
        public Model? Model { get; set; }
        public int? ModelId { get; set; }
        public int? Price { get; set; }
        public string? Currency { get; set; }
        public City? City { get; set; }
        public int? CityId { get; set; }
        public Color? Color { get; set; }
        public int? ColorId { get; set; }
        public VehicleImages? Images { get; set; }
        public int? VehicleImagesId { get; set; }
        public string? Condition { get; set; }
        public int? Year { get; set; }
        public string? BodyType { get; set; }
        public string? FuelType { get; set; }
        public string? Gearbox { get; set; }
        public int? SeatCount { get; set; }
        public string? Gear { get; set; }
        public int? EnginePower { get; set; } // Engine Power (Horsepower)
        public int? Torque { get; set; }
        public string? FuelEfficiency { get; set; }
        public string? Acceleration { get; set; } // Acceleration (0-100 km/h, for example)
        public int? MaximumSpeed { get; set; }
        public string? SafetySystems { get; set; } // Active and Passive Safety Systems (ABS, ESP, airbags, etc.)
        public string? TrunkVolume { get; set; }
        public bool? MultimediaSystem { get; set; } // Multimedia and Navigation System
        public bool? SeatHeating { get; set; }
        public bool? SeatCooling { get; set; }
        public bool? SteeringWheelHeating { get; set; }
        public bool? PowerWindows { get; set; }
        public bool? PowerMirrors { get; set; }
        public bool? AutoParking { get; set; } // Automatic Parking Assistance
        public bool? AdaptiveCruiseControl { get; set; }
        public bool? EmergencyBrakingSystem { get; set; } // Automatic Emergency Braking System
        public bool? RearviewCamera { get; set; }
        public bool? ParkingSensors { get; set; }
        public bool? LEDHeadlights { get; set; }
        public bool? Sunroof { get; set; }
        public bool? PanoramicGlassRoof { get; set; }
        public int? TowingCapacity { get; set; }
        public bool? OffRoadCapability { get; set; } // Off-Road Capabilities (Four-Wheel Drive Systems)
        public string? ClimateControl { get; set; } // Climate Control System
        public bool? AutoAirConditioning { get; set; } // Automatic Air Conditioning
        public bool? OnBoardComputer { get; set; }
        public bool? RemoteLocking { get; set; }
        public bool? StartStop { get; set; } // Start-Stop Technology
    }

}
