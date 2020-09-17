using Microsoft.EntityFrameworkCore.Migrations;

namespace InClassPractice_17Sep.Migrations
{
    public partial class FirstSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "id",
                keyValue: -1);

            migrationBuilder.InsertData(
                table: "Manufacture",
                columns: new[] { "id", "Name", "YearFounded" },
                values: new object[,]
                {
                    { 1, "Chevrolet", 1911 },
                    { 2, "Tesla", null },
                    { 3, "Dodge", null },
                    { 4, "Toyota", 1937 },
                    { 5, "Honda", 1946 },
                    { 6, "Mitsubishi", null },
                    { 7, "Nissan", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Manufacture",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.InsertData(
                table: "Manufacture",
                columns: new[] { "id", "Name", "YearFounded" },
                values: new object[] { -1, "Chevrolet", 1911 });
        }
    }
}
