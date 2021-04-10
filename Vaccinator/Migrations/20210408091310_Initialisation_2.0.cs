using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vaccinator.Migrations
{
    public partial class Initialisation_20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VaccinType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Cible = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    DiscoveryYear = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccinType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Injection",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VaccinTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    PersonneId = table.Column<int>(type: "INTEGER", nullable: false),
                    Marque = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Reference = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    PriseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RappelDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Injection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Injection_Personne_PersonneId",
                        column: x => x.PersonneId,
                        principalTable: "Personne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Injection_VaccinType_VaccinTypeId",
                        column: x => x.VaccinTypeId,
                        principalTable: "VaccinType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Injection_PersonneId",
                table: "Injection",
                column: "PersonneId");

            migrationBuilder.CreateIndex(
                name: "IX_Injection_VaccinTypeId",
                table: "Injection",
                column: "VaccinTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Injection");

            migrationBuilder.DropTable(
                name: "VaccinType");
        }
    }
}
