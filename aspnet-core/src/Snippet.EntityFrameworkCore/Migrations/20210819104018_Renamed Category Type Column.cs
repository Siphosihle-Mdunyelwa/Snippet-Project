using Microsoft.EntityFrameworkCore.Migrations;

namespace Snippet.Migrations
{
    public partial class RenamedCategoryTypeColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppSnippets_AbpUsers_UserId",
                table: "AppSnippets");

            migrationBuilder.DropForeignKey(
                name: "FK_AppTopics_AbpUsers_UserId",
                table: "AppTopics");

            migrationBuilder.RenameColumn(
                name: "Category_Type",
                table: "AppCategory",
                newName: "CategoryType");

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "AppTopics",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "AppSnippets",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_AppSnippets_AbpUsers_UserId",
                table: "AppSnippets",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AppTopics_AbpUsers_UserId",
                table: "AppTopics",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppSnippets_AbpUsers_UserId",
                table: "AppSnippets");

            migrationBuilder.DropForeignKey(
                name: "FK_AppTopics_AbpUsers_UserId",
                table: "AppTopics");

            migrationBuilder.RenameColumn(
                name: "CategoryType",
                table: "AppCategory",
                newName: "Category_Type");

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "AppTopics",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "AppSnippets",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AppSnippets_AbpUsers_UserId",
                table: "AppSnippets",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppTopics_AbpUsers_UserId",
                table: "AppTopics",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
