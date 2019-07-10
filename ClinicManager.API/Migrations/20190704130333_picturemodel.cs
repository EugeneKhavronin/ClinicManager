using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicManager.API.Migrations
{
    public partial class picturemodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ClinicGuid",
                table: "Pictures",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ClinicPicClinicGuid",
                table: "Pictures",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_ClinicPicClinicGuid",
                table: "Pictures",
                column: "ClinicPicClinicGuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_Clinics_ClinicPicClinicGuid",
                table: "Pictures",
                column: "ClinicPicClinicGuid",
                principalTable: "Clinics",
                principalColumn: "ClinicGuid",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_Clinics_ClinicPicClinicGuid",
                table: "Pictures");

            migrationBuilder.DropIndex(
                name: "IX_Pictures_ClinicPicClinicGuid",
                table: "Pictures");

            migrationBuilder.DropColumn(
                name: "ClinicGuid",
                table: "Pictures");

            migrationBuilder.DropColumn(
                name: "ClinicPicClinicGuid",
                table: "Pictures");
        }
    }
}
