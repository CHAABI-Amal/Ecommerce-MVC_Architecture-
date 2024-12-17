using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyShop.Migrations
{
    /// <inheritdoc />
    public partial class EcommerceMVC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bicycles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bicycles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Bicycles",
                columns: new[] { "Id", "Brand", "Color", "ImageFileName", "Model", "Price", "Stock", "Type", "Year" },
                values: new object[,]
                {
                    { 1, "Trek", "Black", "trek-fx1-black.jpg", "FX 1", 450.00m, 0, "Hybrid", 2022 },
                    { 2, "Giant", "Red", "giant-tcr-red.jpg", "TCR Advanced Pro 1 Disc", 3500.00m, 0, "Road", 2023 },
                    { 3, "Specialized", "Blue", "specialized-rockhopper-blue.jpg", "Rockhopper Expert 29", 1100.00m, 0, "Mountain", 2022 },
                    { 4, "Cannondale", "White", "cannondale-synapse-white.jpg", "Synapse Carbon 105", 2000.00m, 0, "Road", 2023 },
                    { 5, "Trek", "Green", "trek-marlin-green.jpg", "Marlin 5", 550.00m, 0, "Mountain", 2022 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bicycles");
        }
    }
}
