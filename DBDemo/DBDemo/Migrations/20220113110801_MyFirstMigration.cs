using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBDemo.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tyres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<double>(type: "float", nullable: false),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearOfMake = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ManufacturerId = table.Column<int>(type: "int", nullable: false),
                    IsWorn = table.Column<bool>(type: "bit", nullable: false),
                    Season = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxPressureBars = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tyres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tyres_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tyres_ManufacturerId",
                table: "Tyres",
                column: "ManufacturerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tyres");

            migrationBuilder.DropTable(
                name: "Manufacturers");
        }
    }
}
