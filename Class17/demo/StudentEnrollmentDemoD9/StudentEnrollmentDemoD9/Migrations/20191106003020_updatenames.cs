using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentEnrollmentDemoD9.Migrations
{
    public partial class updatenames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "Birthdate", "FirstName", "LastName" },
                values: new object[] { 3, new DateTime(2000, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "CandyCane", "Jones" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "Birthdate", "FirstName", "LastName" },
                values: new object[] { 1, new DateTime(2000, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amanda", "Jones" });
        }
    }
}
