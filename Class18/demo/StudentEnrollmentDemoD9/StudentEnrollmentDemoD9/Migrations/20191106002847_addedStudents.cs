using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentEnrollmentDemoD9.Migrations
{
    public partial class addedStudents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Students",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Students",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "Birthdate", "FirstName", "LastName" },
                values: new object[] { 1, new DateTime(2000, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amanda", "Jones" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "Birthdate", "FirstName", "LastName" },
                values: new object[] { 2, new DateTime(1950, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Josie", "Bird" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
