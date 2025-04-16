using CarRental.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CarRental.DataAccess
{
    public class CarRentalStorageContextFactory : IDesignTimeDbContextFactory<CarRentalStorageContext>
    {
        public CarRentalStorageContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CarRentalStorageContext>();


            optionsBuilder.UseSqlServer(
                "Server=tcp:car-rental.database.windows.net,1433;Initial Catalog=CarRentalStorage;Persist Security Info=False;User ID=eliza;Password=dolinka23!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;",
                sqlServerOptionsAction: sqlOptions =>
                {
                    sqlOptions.EnableRetryOnFailure(); 
                });
           // optionsBuilder.UseSqlServer("Server=tcp:car-rental.database.windows.net,1433;Initial Catalog=CarRentalStorage;Persist Security Info=False;User ID=eliza;Password=dolinka23! ;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            return new CarRentalStorageContext(optionsBuilder.Options);
        }
    }
}



