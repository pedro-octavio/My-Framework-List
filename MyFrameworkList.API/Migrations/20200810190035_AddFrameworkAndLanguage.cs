using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFrameworkList.API.Migrations
{
    public partial class AddFrameworkAndLanguage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "Frameworks",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "Frameworks");
        }
    }
}
