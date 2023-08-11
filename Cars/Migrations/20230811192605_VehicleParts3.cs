using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars.Migrations
{
    /// <inheritdoc />
    public partial class VehicleParts3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VehicleImagesId",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "VehicleImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleImages", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleImagesId",
                table: "Vehicles",
                column: "VehicleImagesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_VehicleImages_VehicleImagesId",
                table: "Vehicles",
                column: "VehicleImagesId",
                principalTable: "VehicleImages",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_VehicleImages_VehicleImagesId",
                table: "Vehicles");

            migrationBuilder.DropTable(
                name: "VehicleImages");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_VehicleImagesId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "VehicleImagesId",
                table: "Vehicles");
        }
    }
}
