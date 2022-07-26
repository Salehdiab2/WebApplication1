using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class Arr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(name: "SortedArray", columns: table => new {
                Id = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:Identity", "1, 1"),
                preSorted_position = table.Column<string>(type: "int", nullable: true),
                sorted_position = table.Column<string>(type: "int", nullable: true),
                number = table.Column<decimal>(type: "int", nullable: false),
            }, constraints: table => {
                table.PrimaryKey("PK_IdSort", x => x.Id);
            });
            migrationBuilder.CreateTable(name: "ArrayPosition", columns: table => new {
                Id = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:Identity", "1, 1"),
                position = table.Column<string>(type: "int", nullable: true),
                number = table.Column<decimal>(type: "int", nullable: false),
            }, constraints: table => {
                table.PrimaryKey("PK_IdPost", x => x.Id);
            });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "SortedArray");
            migrationBuilder.DropTable(name: "ArrayPosition");
        }
    }
}
