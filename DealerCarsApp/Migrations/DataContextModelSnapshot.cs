﻿// <auto-generated />
using DealerCarsApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DealerCarsApp.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DealerCarsApp.Model.BodyStyle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BodyType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BodyStyles");
                });

            modelBuilder.Entity("DealerCarsApp.Model.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BrandName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("DealerCarsApp.Model.DriveTrain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DriveTrainType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DriveTrains");
                });

            modelBuilder.Entity("DealerCarsApp.Model.Engine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EngineType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Engines");
                });

            modelBuilder.Entity("DealerCarsApp.Model.Fuel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FuelType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fuel");
                });

            modelBuilder.Entity("DealerCarsApp.Model.Models", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("DealerCarsApp.Model.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("DealerCarsApp.Model.Types", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("DealerCarsApp.Model.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BodyStyleId")
                        .HasColumnType("int");

                    b.Property<int>("DriveTrainId")
                        .HasColumnType("int");

                    b.Property<int>("EngineId")
                        .HasColumnType("int");

                    b.Property<int>("Mileage")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BodyStyleId");

                    b.HasIndex("DriveTrainId");

                    b.HasIndex("EngineId");

                    b.HasIndex("StatusId");

                    b.ToTable("vehicles");
                });

            modelBuilder.Entity("DealerCarsApp.Model.VehicleBrand", b =>
                {
                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.HasKey("VehicleId", "BrandId");

                    b.HasIndex("BrandId");

                    b.ToTable("VehicleBrands");
                });

            modelBuilder.Entity("DealerCarsApp.Model.VehicleFuelType", b =>
                {
                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.Property<int>("FuelTypeId")
                        .HasColumnType("int");

                    b.HasKey("VehicleId", "FuelTypeId");

                    b.HasIndex("FuelTypeId");

                    b.ToTable("VehicleFuelTypes");
                });

            modelBuilder.Entity("DealerCarsApp.Model.VehicleModel", b =>
                {
                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.HasKey("VehicleId", "ModelId");

                    b.HasIndex("ModelId");

                    b.ToTable("VehicleModels");
                });

            modelBuilder.Entity("DealerCarsApp.Model.Models", b =>
                {
                    b.HasOne("DealerCarsApp.Model.Types", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");
                });

            modelBuilder.Entity("DealerCarsApp.Model.Vehicle", b =>
                {
                    b.HasOne("DealerCarsApp.Model.BodyStyle", "BodyStyle")
                        .WithMany("Vehicles")
                        .HasForeignKey("BodyStyleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DealerCarsApp.Model.DriveTrain", "DriveTrain")
                        .WithMany("Vehicles")
                        .HasForeignKey("DriveTrainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DealerCarsApp.Model.Engine", "Engine")
                        .WithMany("Vehicles")
                        .HasForeignKey("EngineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DealerCarsApp.Model.Status", "Status")
                        .WithMany("Vehicles")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BodyStyle");

                    b.Navigation("DriveTrain");

                    b.Navigation("Engine");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("DealerCarsApp.Model.VehicleBrand", b =>
                {
                    b.HasOne("DealerCarsApp.Model.Brand", "Brand")
                        .WithMany("VehicleBrands")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DealerCarsApp.Model.Vehicle", "Vehicle")
                        .WithMany("VehicleBrands")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("DealerCarsApp.Model.VehicleFuelType", b =>
                {
                    b.HasOne("DealerCarsApp.Model.Fuel", "Fuel")
                        .WithMany("VehicleFuelTypes")
                        .HasForeignKey("FuelTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DealerCarsApp.Model.Vehicle", "Vehicle")
                        .WithMany("VehicleFuelTypes")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fuel");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("DealerCarsApp.Model.VehicleModel", b =>
                {
                    b.HasOne("DealerCarsApp.Model.Models", "Model")
                        .WithMany("VehicleModels")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DealerCarsApp.Model.Vehicle", "Vehicle")
                        .WithMany("VehicleModels")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Model");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("DealerCarsApp.Model.BodyStyle", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("DealerCarsApp.Model.Brand", b =>
                {
                    b.Navigation("VehicleBrands");
                });

            modelBuilder.Entity("DealerCarsApp.Model.DriveTrain", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("DealerCarsApp.Model.Engine", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("DealerCarsApp.Model.Fuel", b =>
                {
                    b.Navigation("VehicleFuelTypes");
                });

            modelBuilder.Entity("DealerCarsApp.Model.Models", b =>
                {
                    b.Navigation("VehicleModels");
                });

            modelBuilder.Entity("DealerCarsApp.Model.Status", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("DealerCarsApp.Model.Vehicle", b =>
                {
                    b.Navigation("VehicleBrands");

                    b.Navigation("VehicleFuelTypes");

                    b.Navigation("VehicleModels");
                });
#pragma warning restore 612, 618
        }
    }
}