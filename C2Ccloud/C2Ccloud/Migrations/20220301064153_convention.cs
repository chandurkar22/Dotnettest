using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C2Bcloud.Migrations
{
    public partial class convention : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_employees",
                table: "employees");

            migrationBuilder.RenameTable(
                name: "employees",
                newName: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "ClientsID",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ClientsID",
                table: "Employees",
                column: "ClientsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Clients_ClientsID",
                table: "Employees",
                column: "ClientsID",
                principalTable: "Clients",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Clients_ClientsID",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ClientsID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ClientsID",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "employees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_employees",
                table: "employees",
                column: "ID");
        }
    }
}
