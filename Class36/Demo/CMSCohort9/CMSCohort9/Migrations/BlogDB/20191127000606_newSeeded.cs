using Microsoft.EntityFrameworkCore.Migrations;

namespace CMSCohort9.Migrations.BlogDB
{
    public partial class newSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "ID", "Content", "Title" },
                values: new object[,]
                {
                    { 1, "This is my first post, and it's pretty super duper cool", "Hello World" },
                    { 2, "Oh, you can’t help that,” said the Cat: “we’re all mad here. I’m mad. You’re mad.” “How do you know I’m mad?” said Alice. “You must be,” said the Cat, or you wouldn’t have come here.", "We're All Mad" },
                    { 3, "It's no use going back to yesterday, because I was a different person then.", "Yesterday" },
                    { 4, "She generally gave herself very good advice (though she very seldom followed it)", "Good advice" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 4);
        }
    }
}
