using CarRental.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRental.DataAccess
{
    public class CarRentalStorageContext : DbContext
    {
        public CarRentalStorageContext(DbContextOptions<CarRentalStorageContext> opt) : base(opt)
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<RentalData> RentalsData { get; set; }

    }
}
