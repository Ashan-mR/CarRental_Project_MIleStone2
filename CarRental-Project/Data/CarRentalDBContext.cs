using CarRental_Project.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRental_Project.Data
{
    public class CarRentalDBContext : DbContext
    {
        public CarRentalDBContext(DbContextOptions<CarRentalDBContext> options) : base(options)
        {

        }

        public DbSet<Car>Cars { get; set; }
        public DbSet<Management>Managers { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Customer> Customers { get; set; }   
    }
}
