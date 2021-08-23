using Microsoft.EntityFrameworkCore.Migrations;

namespace Snippet.Migrations
{
    public partial class AddedNameColumnOnCodeSnnipet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Language",
                table: "AppSnippets",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AppSnippets",
                newName: "Language");
        }
    }
}
