using Microsoft.EntityFrameworkCore;

namespace ServiceStation.Web.Models
{
    public class ServiceDBContext: DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleService> VehicleServices { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public ServiceDBContext(DbContextOptions<ServiceDBContext>options): base(options) 
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=DESKTOP-AON4KTQ\SQLEXPRESS;Database=AutoServiceStation;Trusted_Connection=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
