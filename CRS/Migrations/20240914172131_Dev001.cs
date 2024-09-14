using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRS.Migrations
{
    /// <inheritdoc />
    public partial class Dev001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true),
                    LicensePlate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    VIN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FuelType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TransmissionType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Seats = table.Column<int>(type: "int", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    RentalPricePerDay = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    isAvailable = table.Column<bool>(type: "bit", nullable: true),
                    Milage = table.Column<int>(type: "int", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreatedDttm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDttm = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NIC = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedDttm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDttm = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Drivers");
        }
    }
}
