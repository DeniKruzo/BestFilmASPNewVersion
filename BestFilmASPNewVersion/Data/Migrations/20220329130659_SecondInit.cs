using Microsoft.EntityFrameworkCore.Migrations;

namespace BestFilmASPNewVersion.Data.Migrations
{
    public partial class SecondInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Realease = table.Column<int>(nullable: false),
                    Rating = table.Column<float>(nullable: false),
                    Discription = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: true),
                    Actor = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
