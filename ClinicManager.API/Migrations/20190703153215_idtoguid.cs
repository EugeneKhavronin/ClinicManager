using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicManager.API.Migrations
{
    public partial class idtoguid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PictureId",
                table: "Pictures",
                newName: "PictureGuid");

            migrationBuilder.RenameColumn(
                name: "PictureId",
                table: "Clinics",
                newName: "PictureGuid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PictureGuid",
                table: "Pictures",
                newName: "PictureId");

            migrationBuilder.RenameColumn(
                name: "PictureGuid",
                table: "Clinics",
                newName: "PictureId");
        }
    }
}
