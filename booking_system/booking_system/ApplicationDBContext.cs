using booking_system.Entities;
using Microsoft.EntityFrameworkCore;

namespace booking_system
{
    public class ApplicationDBContext:DbContext
    {
        public DbSet<Location> Locations { get; set; }
        public DbSet<Table> RestaurantTables { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Person> Persons { get; set; }


        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
