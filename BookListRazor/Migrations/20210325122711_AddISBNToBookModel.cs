using Microsoft.EntityFrameworkCore.Migrations;

namespace BookListRazor.Migrations
{
    public partial class AddISBNToBookModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Book",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "ISBN",
                table: "Book",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ISBN",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Book",
                newName: "name");
        }
    }
}
