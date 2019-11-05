using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentEnrollmentDemoD9.Migrations
{
    public partial class addedSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "ID", "CourseCode", "Price", "Technology" },
                values: new object[] { 1, "Seattle-Dotnet-401d9", 100m, 3 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "ID", "CourseCode", "Price", "Technology" },
                values: new object[] { 2, "Java", 110m, 4 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "ID", "CourseCode", "Price", "Technology" },
                values: new object[] { 3, "Vim", 150m, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
