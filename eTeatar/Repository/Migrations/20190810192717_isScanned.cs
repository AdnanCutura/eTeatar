using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class isScanned : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSkenirana",
                table: "Narudzba",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSkenirana",
                table: "Narudzba");
        }
    }
}
