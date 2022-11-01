using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Data.Migrations
{
    public partial class hell : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "RoleClaimtable",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetRoleClaims",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "check",
                table: "AspNetRoleClaims",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetRoleClaims");

            migrationBuilder.DropColumn(
                name: "check",
                table: "AspNetRoleClaims");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "RoleClaimtable",
                newName: "id");
        }
    }
}
