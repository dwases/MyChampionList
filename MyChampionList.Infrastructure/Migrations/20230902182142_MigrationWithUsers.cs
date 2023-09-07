using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyChampionList.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MigrationWithUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LikedCounter",
                table: "Champions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrashedCounter",
                table: "Champions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrueLoveCounter",
                table: "Champions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrueLoveId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LikedChamp",
                columns: table => new
                {
                    ChampionId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikedChamp", x => new { x.UserId, x.ChampionId });
                    table.ForeignKey(
                        name: "FK_LikedChamp_Champions_ChampionId",
                        column: x => x.ChampionId,
                        principalTable: "Champions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LikedChamp_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrashedChamp",
                columns: table => new
                {
                    ChampionId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrashedChamp", x => new { x.UserId, x.ChampionId });
                    table.ForeignKey(
                        name: "FK_TrashedChamp_Champions_ChampionId",
                        column: x => x.ChampionId,
                        principalTable: "Champions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrashedChamp_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LikedChamp_ChampionId",
                table: "LikedChamp",
                column: "ChampionId");

            migrationBuilder.CreateIndex(
                name: "IX_TrashedChamp_ChampionId",
                table: "TrashedChamp",
                column: "ChampionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LikedChamp");

            migrationBuilder.DropTable(
                name: "TrashedChamp");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropColumn(
                name: "LikedCounter",
                table: "Champions");

            migrationBuilder.DropColumn(
                name: "TrashedCounter",
                table: "Champions");

            migrationBuilder.DropColumn(
                name: "TrueLoveCounter",
                table: "Champions");
        }
    }
}
