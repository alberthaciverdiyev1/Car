using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars.Migrations
{
    /// <inheritdoc />
    public partial class VehicleParts4AndAppuserPart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Vehicles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_AppUserId",
                table: "Vehicles",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_AspNetUsers_AppUserId",
                table: "Vehicles",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_AspNetUsers_AppUserId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_AppUserId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Vehicles");
        }
    }
}
