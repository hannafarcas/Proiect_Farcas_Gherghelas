using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect_Farcas_Gherghelas.Migrations
{
    public partial class Produse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipProdus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marime = table.Column<int>(type: "int", nullable: false),
                    Inaltime = table.Column<int>(type: "int", nullable: false),
                    Pret = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InchiriereID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Produs_Inchiriere_InchiriereID",
                        column: x => x.InchiriereID,
                        principalTable: "Inchiriere",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produs_InchiriereID",
                table: "Produs",
                column: "InchiriereID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produs");
        }
    }
}
