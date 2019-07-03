using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicManager.API.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClinicId",
                table: "Clinics",
                newName: "ClinicGuid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClinicGuid",
                table: "Clinics",
                newName: "ClinicId");
        }
    }
}
