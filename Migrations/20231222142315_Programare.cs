using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect_Farcas_Gherghelas.Migrations
{
    public partial class Programare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programare_Inchiriere_InchiriereID1",
                table: "Programare");

            migrationBuilder.DropIndex(
                name: "IX_Programare_InchiriereID1",
                table: "Programare");

            migrationBuilder.DropColumn(
                name: "InchiriereID1",
                table: "Programare");

            migrationBuilder.AlterColumn<int>(
                name: "InchiriereID",
                table: "Programare",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Programare_InchiriereID",
                table: "Programare",
                column: "InchiriereID");

            migrationBuilder.AddForeignKey(
                name: "FK_Programare_Inchiriere_InchiriereID",
                table: "Programare",
                column: "InchiriereID",
                principalTable: "Inchiriere",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programare_Inchiriere_InchiriereID",
                table: "Programare");

            migrationBuilder.DropIndex(
                name: "IX_Programare_InchiriereID",
                table: "Programare");

            migrationBuilder.AlterColumn<string>(
                name: "InchiriereID",
                table: "Programare",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InchiriereID1",
                table: "Programare",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Programare_InchiriereID1",
                table: "Programare",
                column: "InchiriereID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Programare_Inchiriere_InchiriereID1",
                table: "Programare",
                column: "InchiriereID1",
                principalTable: "Inchiriere",
                principalColumn: "ID");
        }
    }
}
