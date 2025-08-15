using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Todo.Migrations
{
    /// <inheritdoc />
    public partial class MigrationTodoUndCategoryUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                schema: "paul",
                table: "TodoItems");

            migrationBuilder.AddColumn<string>(
                name: "CategoryName",
                schema: "paul",
                table: "TodoItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryName",
                schema: "paul",
                table: "TodoItems");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                schema: "paul",
                table: "TodoItems",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
