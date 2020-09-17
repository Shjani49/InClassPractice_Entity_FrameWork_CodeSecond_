using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InClassPractice_17Sep.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Manufacture",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(10)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(30)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_general_ci"),
                    YearFounded = table.Column<int>(type: "int(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacture", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Manufacture",
                columns: new[] { "id", "Name", "YearFounded" },
                values: new object[] { -1, "Chevrolet", 1911 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Manufacture");
        }
    }
}
