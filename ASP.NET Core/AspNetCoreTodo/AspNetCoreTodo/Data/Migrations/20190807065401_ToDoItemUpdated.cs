using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreTodo.Data.Migrations
{
    public partial class ToDoItemUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Item",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Item");
        }
    }
}
