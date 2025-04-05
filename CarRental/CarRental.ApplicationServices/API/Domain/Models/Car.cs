namespace CarRental.ApplicationServices.API.Domain.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int YearOfProduction { get; set; }
        public bool Availability { get; set; }

    }
}
