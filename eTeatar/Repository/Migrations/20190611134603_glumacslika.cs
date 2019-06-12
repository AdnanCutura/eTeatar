using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class glumacslika : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SlikaLink",
                table: "Glumac");

            migrationBuilder.AddColumn<byte[]>(
                name: "Slika",
                table: "Glumac",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slika",
                table: "Glumac");

            migrationBuilder.AddColumn<string>(
                name: "SlikaLink",
                table: "Glumac",
                nullable: true);
        }
    }
}
