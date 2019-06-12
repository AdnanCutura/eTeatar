using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class KorisnickiNalogSlika : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KorisnickiNalog_Avatar_AvatarId",
                table: "KorisnickiNalog");

            migrationBuilder.DropTable(
                name: "Avatar");

            migrationBuilder.DropIndex(
                name: "IX_KorisnickiNalog_AvatarId",
                table: "KorisnickiNalog");

            migrationBuilder.DropColumn(
                name: "AvatarId",
                table: "KorisnickiNalog");

            migrationBuilder.AddColumn<byte[]>(
                name: "Slika",
                table: "KorisnickiNalog",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slika",
                table: "KorisnickiNalog");

            migrationBuilder.AddColumn<string>(
                name: "AvatarId",
                table: "KorisnickiNalog",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Avatar",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Link = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avatar", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KorisnickiNalog_AvatarId",
                table: "KorisnickiNalog",
                column: "AvatarId");

            migrationBuilder.AddForeignKey(
                name: "FK_KorisnickiNalog_Avatar_AvatarId",
                table: "KorisnickiNalog",
                column: "AvatarId",
                principalTable: "Avatar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
