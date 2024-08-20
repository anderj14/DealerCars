using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DealerCarsApp.Data.migrations
{
    /// <inheritdoc />
    public partial class EntitiesChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BodyStyles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BodyTypeName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyStyles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BrandName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DriveTrains",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DriveTrainName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriveTrains", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Engines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EngineTypeName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fuels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FuelName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fuels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StatusName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ModelName = table.Column<string>(type: "TEXT", nullable: false),
                    BrandId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TrimName = table.Column<string>(type: "TEXT", nullable: false),
                    ModelsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trims_Models_ModelsId",
                        column: x => x.ModelsId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Owner = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Mileage = table.Column<int>(type: "INTEGER", nullable: false),
                    VIN = table.Column<string>(type: "TEXT", nullable: false),
                    FuelEfficiency = table.Column<double>(type: "REAL", nullable: false),
                    Color = table.Column<string>(type: "TEXT", nullable: false),
                    NumberOfDoors = table.Column<int>(type: "INTEGER", nullable: false),
                    ExteriorFeatures = table.Column<string>(type: "TEXT", nullable: false),
                    InteriorFeatures = table.Column<string>(type: "TEXT", nullable: false),
                    HasABS = table.Column<bool>(type: "INTEGER", nullable: false),
                    HasAirbags = table.Column<bool>(type: "INTEGER", nullable: false),
                    HasStabilityControl = table.Column<bool>(type: "INTEGER", nullable: false),
                    HasTractionControl = table.Column<bool>(type: "INTEGER", nullable: false),
                    HasRearviewCamera = table.Column<bool>(type: "INTEGER", nullable: false),
                    HasBlindSpotMonitoring = table.Column<bool>(type: "INTEGER", nullable: false),
                    HasLaneDepartureWarning = table.Column<bool>(type: "INTEGER", nullable: false),
                    HasAutomaticEmergencyBraking = table.Column<bool>(type: "INTEGER", nullable: false),
                    BrandId = table.Column<int>(type: "INTEGER", nullable: false),
                    ModelsId = table.Column<int>(type: "INTEGER", nullable: false),
                    StatusId = table.Column<int>(type: "INTEGER", nullable: false),
                    BodyStyleId = table.Column<int>(type: "INTEGER", nullable: false),
                    EngineId = table.Column<int>(type: "INTEGER", nullable: false),
                    DriveTrainId = table.Column<int>(type: "INTEGER", nullable: false),
                    FuelId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_BodyStyles_BodyStyleId",
                        column: x => x.BodyStyleId,
                        principalTable: "BodyStyles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_DriveTrains_DriveTrainId",
                        column: x => x.DriveTrainId,
                        principalTable: "DriveTrains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_Engines_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_Fuels_FuelId",
                        column: x => x.FuelId,
                        principalTable: "Fuels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_Models_ModelsId",
                        column: x => x.ModelsId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Models_BrandId",
                table: "Models",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Trims_ModelsId",
                table: "Trims",
                column: "ModelsId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_BodyStyleId",
                table: "Vehicles",
                column: "BodyStyleId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_BrandId",
                table: "Vehicles",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_DriveTrainId",
                table: "Vehicles",
                column: "DriveTrainId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_EngineId",
                table: "Vehicles",
                column: "EngineId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_FuelId",
                table: "Vehicles",
                column: "FuelId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_ModelsId",
                table: "Vehicles",
                column: "ModelsId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_StatusId",
                table: "Vehicles",
                column: "StatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trims");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "BodyStyles");

            migrationBuilder.DropTable(
                name: "DriveTrains");

            migrationBuilder.DropTable(
                name: "Engines");

            migrationBuilder.DropTable(
                name: "Fuels");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
