using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VeriBilisimCase.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ILs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ILs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ilces",
                columns: table => new
                {
                    IlceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ilID = table.Column<int>(type: "int", nullable: true),
                    IlceAd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilces", x => x.IlceID);
                    table.ForeignKey(
                        name: "FK_Ilces_ILs_ilID",
                        column: x => x.ilID,
                        principalTable: "ILs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Adays",
                columns: table => new
                {
                    AdayID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasvuruTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ILID = table.Column<int>(type: "int", nullable: true),
                    IlceID = table.Column<int>(type: "int", nullable: true),
                    SeyahatEngeli = table.Column<bool>(type: "bit", nullable: false),
                    IsyeriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pozisyon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adays", x => x.AdayID);
                    table.ForeignKey(
                        name: "FK_Adays_Ilces_IlceID",
                        column: x => x.IlceID,
                        principalTable: "Ilces",
                        principalColumn: "IlceID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adays_ILs_ILID",
                        column: x => x.ILID,
                        principalTable: "ILs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonelSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ILID = table.Column<int>(type: "int", nullable: true),
                    IlceID = table.Column<int>(type: "int", nullable: true),
                    Cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Personels_Ilces_IlceID",
                        column: x => x.IlceID,
                        principalTable: "Ilces",
                        principalColumn: "IlceID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personels_ILs_ILID",
                        column: x => x.ILID,
                        principalTable: "ILs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adays_IlceID",
                table: "Adays",
                column: "IlceID");

            migrationBuilder.CreateIndex(
                name: "IX_Adays_ILID",
                table: "Adays",
                column: "ILID");

            migrationBuilder.CreateIndex(
                name: "IX_Ilces_ilID",
                table: "Ilces",
                column: "ilID");

            migrationBuilder.CreateIndex(
                name: "IX_Personels_IlceID",
                table: "Personels",
                column: "IlceID");

            migrationBuilder.CreateIndex(
                name: "IX_Personels_ILID",
                table: "Personels",
                column: "ILID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adays");

            migrationBuilder.DropTable(
                name: "Personels");

            migrationBuilder.DropTable(
                name: "Ilces");

            migrationBuilder.DropTable(
                name: "ILs");
        }
    }
}
