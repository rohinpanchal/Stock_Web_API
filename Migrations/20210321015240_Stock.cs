using Microsoft.EntityFrameworkCore.Migrations;
using System.IO;

namespace Stock_Web_API.Migrations
{
    public partial class Stock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    NumberOfStocks = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.Id);
                });
            var sqlFile = Path.Combine(".\\DatabaseScripts", @"data.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stock");
        }
    }
}
