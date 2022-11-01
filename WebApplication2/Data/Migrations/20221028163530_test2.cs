using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Data.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Selected",
                table: "UserPermission");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "UserPermission");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "UserPermission",
                newName: "ValueId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ValueId",
                table: "UserPermission",
                newName: "Value");

            migrationBuilder.AddColumn<bool>(
                name: "Selected",
                table: "UserPermission",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "UserPermission",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
