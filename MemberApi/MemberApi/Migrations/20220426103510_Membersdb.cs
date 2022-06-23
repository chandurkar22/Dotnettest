using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MemberApi.Migrations
{
    public partial class Membersdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Members",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "projectname",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "projectname",
                table: "Clients");
        }
    }
}
