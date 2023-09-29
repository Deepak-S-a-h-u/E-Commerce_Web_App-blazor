using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class car : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cars",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    seller_name = table.Column<string>(type: "text", nullable: false),
                    seller_mobile = table.Column<string>(type: "text", nullable: false),
                    brand = table.Column<int>(type: "integer", nullable: false),
                    model_year = table.Column<DateOnly>(type: "date", nullable: false),
                    fuel = table.Column<int>(type: "integer", nullable: false),
                    transmission = table.Column<int>(type: "integer", nullable: false),
                    distance_driven = table.Column<int>(type: "integer", nullable: false),
                    owner_no = table.Column<int>(type: "integer", nullable: false),
                    pin_code = table.Column<int>(type: "integer", nullable: false),
                    title = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    images = table.Column<string[]>(type: "text[]", nullable: false),
                    price = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cars", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cars");
        }
    }
}
