using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars.Migrations
{
    /// <inheritdoc />
    public partial class VehicleParts2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Acceleration",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AdaptiveCruiseControl",
                table: "Vehicles",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AutoAirConditioning",
                table: "Vehicles",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AutoParking",
                table: "Vehicles",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClimateControl",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmergencyBrakingSystem",
                table: "Vehicles",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EnginePower",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FuelEfficiency",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gear",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "LEDHeadlights",
                table: "Vehicles",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaximumSpeed",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MultimediaSystem",
                table: "Vehicles",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OffRoadCapability",
                table: "Vehicles",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OnBoardComputer",
                table: "Vehicles",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PanoramicGlassRoof",
                table: "Vehicles",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ParkingSensors",
                table: "Vehicles",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PowerMirrors",
                table: "Vehicles",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PowerWindows",
                table: "Vehicles",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RearviewCamera",
                table: "Vehicles",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RemoteLocking",
                table: "Vehicles",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SafetySystems",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SeatCooling",
                table: "Vehicles",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SeatHeating",
                table: "Vehicles",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "StartStop",
                table: "Vehicles",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SteeringWheelHeating",
                table: "Vehicles",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Sunroof",
                table: "Vehicles",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Torque",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TowingCapacity",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrunkVolume",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_ColorId",
                table: "Vehicles",
                column: "ColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Colors_ColorId",
                table: "Vehicles",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Colors_ColorId",
                table: "Vehicles");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_ColorId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Acceleration",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "AdaptiveCruiseControl",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "AutoAirConditioning",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "AutoParking",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ClimateControl",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "EmergencyBrakingSystem",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "EnginePower",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "FuelEfficiency",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Gear",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "LEDHeadlights",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "MaximumSpeed",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "MultimediaSystem",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "OffRoadCapability",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "OnBoardComputer",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "PanoramicGlassRoof",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ParkingSensors",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "PowerMirrors",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "PowerWindows",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "RearviewCamera",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "RemoteLocking",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "SafetySystems",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "SeatCooling",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "SeatHeating",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "StartStop",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "SteeringWheelHeating",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Sunroof",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Torque",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "TowingCapacity",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "TrunkVolume",
                table: "Vehicles");
        }
    }
}
