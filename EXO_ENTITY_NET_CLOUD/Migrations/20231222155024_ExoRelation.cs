using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EXO_ENTITY_NET_CLOUD.Migrations
{
    public partial class ExoRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "personnes",
                columns: table => new
                {
                    PersonneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personnes", x => x.PersonneId);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    FilmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AnneeDeSortie = table.Column<int>(type: "int", nullable: false),
                    RealisateurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.FilmId);
                    table.CheckConstraint("CK_Annee", "AnneeDeSortie > 1975");
                    table.ForeignKey(
                        name: "FK_Films_personnes_RealisateurId",
                        column: x => x.RealisateurId,
                        principalTable: "personnes",
                        principalColumn: "PersonneId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "FilmPersonne",
                columns: table => new
                {
                    PersonneId = table.Column<int>(type: "int", nullable: false),
                    FilmId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmPersonne", x => new { x.PersonneId, x.FilmId });
                    table.ForeignKey(
                        name: "FK_FilmPersonne_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "FilmId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_FilmPersonne_personnes_PersonneId",
                        column: x => x.PersonneId,
                        principalTable: "personnes",
                        principalColumn: "PersonneId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "personnes",
                columns: new[] { "PersonneId", "Nom", "Prenom" },
                values: new object[,]
                {
                    { 1, "Wood", "Elijah" },
                    { 2, "Hunnam", "Charlie" },
                    { 3, "Ford", "Harisson" },
                    { 4, "Hammil", "Mark" },
                    { 5, "Fisher", "Carrie" },
                    { 6, "Mortensen", "Vigo" },
                    { 7, "Bloom", "Orlando" },
                    { 8, "Alexander", "Lexi" },
                    { 9, "Jackson", "Peter" },
                    { 10, "Lucas", "Georges" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmId", "AnneeDeSortie", "Genre", "RealisateurId", "Titre" },
                values: new object[,]
                {
                    { 1, 1977, "Science-Fiction", 10, "Star Wars : Un nouvel espoir" },
                    { 2, 1980, "Science-Fiction", 10, "Star Wars : L'empire contre-attaque" },
                    { 3, 1983, "Science-Fiction", 10, "Star Wars : Le retour du Jedi" },
                    { 4, 2005, "Société", 8, "Hooligans" },
                    { 5, 2001, "Heroic-Fantasy", 9, "LOTR - La communauté de l'anneau" },
                    { 6, 2002, "Heroic-Fantasy", 9, "LOTR - Les deux tours" },
                    { 7, 2003, "Heroic-Fantasy", 9, "LOTR - Le retour du roi" }
                });

            migrationBuilder.InsertData(
                table: "FilmPersonne",
                columns: new[] { "FilmId", "PersonneId" },
                values: new object[,]
                {
                    { 4, 1 },
                    { 5, 1 },
                    { 6, 1 },
                    { 7, 1 },
                    { 4, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 3 },
                    { 1, 4 },
                    { 2, 4 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 5 },
                    { 3, 5 },
                    { 5, 6 },
                    { 6, 6 },
                    { 7, 6 },
                    { 5, 7 },
                    { 6, 7 },
                    { 7, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmPersonne_FilmId",
                table: "FilmPersonne",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_Films_RealisateurId",
                table: "Films",
                column: "RealisateurId");

            migrationBuilder.CreateIndex(
                name: "IX_Films_Titre",
                table: "Films",
                column: "Titre",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmPersonne");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "personnes");
        }
    }
}
