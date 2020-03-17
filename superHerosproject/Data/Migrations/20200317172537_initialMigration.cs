using Microsoft.EntityFrameworkCore.Migrations;

namespace superHerosproject.Data.Migrations
{
    public partial class  initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    superHeroName = table.Column<string>(nullable: false),
                    alterEgo = table.Column<string>(nullable: true),
                    primaryAbility = table.Column<string>(nullable: true),
                    secondaryAbility = table.Column<string>(nullable: true),
                    catchPhrase = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.superHeroName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
