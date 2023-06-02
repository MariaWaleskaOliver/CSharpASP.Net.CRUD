using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    InventoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataOfInventory = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.InventoryId);
                });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "InventoryId", "DataOfInventory", "ProductContent", "Quantity" },
                values: new object[] { 1, new DateTime(2015, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Calander New Generation", 10 });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "InventoryId", "DataOfInventory", "ProductContent", "Quantity" },
                values: new object[] { 2, new DateTime(2020, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pencil MultiColor ", 7 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventories");
        }
    }
}
