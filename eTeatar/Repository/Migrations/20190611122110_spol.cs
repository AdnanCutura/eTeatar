using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class spol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SpolId",
                table: "Glumac",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Spol",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spol", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Glumac_SpolId",
                table: "Glumac",
                column: "SpolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Glumac_Spol_SpolId",
                table: "Glumac",
                column: "SpolId",
                principalTable: "Spol",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Glumac_Spol_SpolId",
                table: "Glumac");

            migrationBuilder.DropTable(
                name: "Spol");

            migrationBuilder.DropIndex(
                name: "IX_Glumac_SpolId",
                table: "Glumac");

            migrationBuilder.DropColumn(
                name: "SpolId",
                table: "Glumac");
        }
    }
}
