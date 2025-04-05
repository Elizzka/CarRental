using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CarRental.DataAccess
{
    public class CarRentalStorageContextFactory : IDesignTimeDbContextFactory<CarRentalStorageContext>
    {
        public CarRentalStorageContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CarRentalStorageContext>();
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS01;Initial Catalog=CarRentalStorage;Integrated Security=True;Trust Server Certificate=True");
            return new CarRentalStorageContext(optionsBuilder.Options);
        }
    }
}
