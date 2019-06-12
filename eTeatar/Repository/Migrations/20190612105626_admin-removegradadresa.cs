using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class adminremovegradadresa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adresa",
                table: "KorisnickiNalog");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adresa",
                table: "KorisnickiNalog",
                nullable: true);
        }
    }
}
