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
        public DbSet<Fuel> Fuel { get; set; }
        public DbSet<Models> Models { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Types> Types { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleBrand> VehicleBrands { get; set; }
        public DbSet<VehicleFuelType> VehicleFuelTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleBrand>()
                .HasKey(vb => new { vb.VehicleId, vb.BrandId });
            modelBuilder.Entity<VehicleBrand>()
                .HasOne(v => v.Vehicle)
                .WithMany(vb => vb.VehicleBrands)
                .HasForeignKey(v => v.VehicleId);
            modelBuilder.Entity<VehicleBrand>()
                .HasOne(b => b.Brand)
                .WithMany(vb => vb.VehicleBrands)
                .HasForeignKey(b => b.BrandId);

            modelBuilder.Entity<VehicleFuelType>()
                .HasKey(vft => new { vft.VehicleId, vft.FuelTypeId });
            modelBuilder.Entity<VehicleFuelType>()
                .HasOne(v => v.Vehicle)
                .WithMany(vft => vft.VehicleFuelTypes)
                .HasForeignKey(v => v.VehicleId);
            modelBuilder.Entity<VehicleFuelType>()
                .HasOne(ft => ft.Fuel)
                .WithMany(vft => vft.VehicleFuelTypes)
                .HasForeignKey(ft => ft.FuelTypeId);
        }

    }
}
