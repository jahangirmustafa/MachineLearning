using Microsoft.EntityFrameworkCore.Migrations;

namespace Tesla.Migrations
{
    public partial class ContentToSentimentText : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Reviews");

            migrationBuilder.AddColumn<string>(
                name: "SentimentText",
                table: "Reviews",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SentimentText",
                table: "Reviews");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
