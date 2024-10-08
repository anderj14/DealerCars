﻿// <auto-generated />
using System;
using DealerCarsApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DealerCarsApp.Data.migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("DealerCarsApp.Model.BodyStyle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BodyTypeName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("BodyStyles");
                });

            modelBuilder.Entity("DealerCarsApp.Model.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("DealerCarsApp.Model.DriveTrain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DriveTrainName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DriveTrains");
                });

            modelBuilder.Entity("DealerCarsApp.Model.Engine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("EngineTypeName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Engines");
                });

            modelBuilder.Entity("DealerCarsApp.Model.Fuel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FuelName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Fuels");
                });

            modelBuilder.Entity("DealerCarsApp.Model.Models", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BrandId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("DealerCarsApp.Model.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("DealerCarsApp.Model.Trim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ModelsId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TrimName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ModelsId");

                    b.ToTable("Trims");
                });

            modelBuilder.Entity("DealerCarsApp.Model.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BodyStyleId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BrandId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("TEXT");

                    b.Property<int>("DriveTrainId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EngineId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ExteriorFeatures")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("FuelEfficiency")
                        .HasColumnType("REAL");

                    b.Property<int>("FuelId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HasABS")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HasAirbags")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HasAutomaticEmergencyBraking")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HasBlindSpotMonitoring")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HasLaneDepartureWarning")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HasRearviewCamera")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HasStabilityControl")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HasTractionControl")
                        .HasColumnType("INTEGER");

                    b.Property<string>("InteriorFeatures")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Mileage")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ModelsId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NumberOfDoors")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("StatusId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("VIN")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BodyStyleId");

                    b.HasIndex("BrandId");

                    b.HasIndex("DriveTrainId");

                    b.HasIndex("EngineId");

                    b.HasIndex("FuelId");

                    b.HasIndex("ModelsId");

                    b.HasIndex("StatusId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("DealerCarsApp.Model.Models", b =>
                {
                    b.HasOne("DealerCarsApp.Model.Brand", "Brand")
                        .WithMany("Models")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("DealerCarsApp.Model.Trim", b =>
                {
                    b.HasOne("DealerCarsApp.Model.Models", "Models")
                        .WithMany("Trim")
                        .HasForeignKey("ModelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Models");
                });

            modelBuilder.Entity("DealerCarsApp.Model.Vehicle", b =>
                {
                    b.HasOne("DealerCarsApp.Model.BodyStyle", "BodyStyle")
                        .WithMany("Vehicles")
                        .HasForeignKey("BodyStyleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DealerCarsApp.Model.Brand", "Brand")
                        .WithMany("Vehicles")
                        .HasForeignKey("BrandId")
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

                    b.HasOne("DealerCarsApp.Model.Fuel", "Fuel")
                        .WithMany("Vehicles")
                        .HasForeignKey("FuelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DealerCarsApp.Model.Models", "Models")
                        .WithMany()
                        .HasForeignKey("ModelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DealerCarsApp.Model.Status", "Status")
                        .WithMany("Vehicles")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BodyStyle");

                    b.Navigation("Brand");

                    b.Navigation("DriveTrain");

                    b.Navigation("Engine");

                    b.Navigation("Fuel");

                    b.Navigation("Models");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("DealerCarsApp.Model.BodyStyle", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("DealerCarsApp.Model.Brand", b =>
                {
                    b.Navigation("Models");

                    b.Navigation("Vehicles");
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
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("DealerCarsApp.Model.Models", b =>
                {
                    b.Navigation("Trim");
                });

            modelBuilder.Entity("DealerCarsApp.Model.Status", b =>
                {
                    b.Navigation("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
