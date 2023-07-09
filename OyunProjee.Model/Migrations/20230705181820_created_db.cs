using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OyunProjee.Model.Migrations
{
    public partial class created_db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Oyuns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OyunAdı = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    KurulusTarihi = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: true),
                    Türü = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oyuns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Karakters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OyunAdı = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OyuncuAdı = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OyuncuOzellikleri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gucu = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Vurus = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    FızıkselOzellik = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    OyunId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Karakters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Karakters_Oyuns_OyunId",
                        column: x => x.OyunId,
                        principalTable: "Oyuns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Karakters_OyunId",
                table: "Karakters",
                column: "OyunId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Karakters");

            migrationBuilder.DropTable(
                name: "Oyuns");
        }
    }
}
