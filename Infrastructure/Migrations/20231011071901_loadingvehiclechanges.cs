using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class loadingvehiclechanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "images",
                table: "vehicles");

            migrationBuilder.AddColumn<byte[]>(
                name: "file_data",
                table: "vehicles",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "file_name",
                table: "vehicles",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "file_data",
                table: "vehicles");

            migrationBuilder.DropColumn(
                name: "file_name",
                table: "vehicles");

            migrationBuilder.AddColumn<string[]>(
                name: "images",
                table: "vehicles",
                type: "text[]",
                nullable: false,
                defaultValue: new string[0]);
        }
    }
}
