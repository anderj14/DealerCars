using DealerCarsApp.Model;
using Microsoft.EntityFrameworkCore;

namespace DealerCarsApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<BodyStyle> BodyStyles { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<DriveTrain> DriveTrains { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<Models> Models { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Trim> Trims { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
