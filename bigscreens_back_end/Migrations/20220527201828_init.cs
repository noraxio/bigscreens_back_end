using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bigscreens_back_end.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Showings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShowingTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Showings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Showroom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalSeats = table.Column<int>(type: "int", nullable: false),
                    ScreenSize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Showroom", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RunTime = table.Column<int>(type: "int", nullable: false),
                    Genres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlotSummery = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PgLevel = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    ShowingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Showings_ShowingId",
                        column: x => x.ShowingId,
                        principalTable: "Showings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reservedseat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Seatnummber = table.Column<int>(type: "int", nullable: false),
                    ShowingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservedseat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservedseat_Showings_ShowingId",
                        column: x => x.ShowingId,
                        principalTable: "Showings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Soldseat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketNummber = table.Column<int>(type: "int", nullable: false),
                    SeatNummber = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ShowingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Soldseat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Soldseat_Showings_ShowingId",
                        column: x => x.ShowingId,
                        principalTable: "Showings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ShowingShowroom",
                columns: table => new
                {
                    ShowroomsId = table.Column<int>(type: "int", nullable: false),
                    ShowsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShowingShowroom", x => new { x.ShowroomsId, x.ShowsId });
                    table.ForeignKey(
                        name: "FK_ShowingShowroom_Showings_ShowsId",
                        column: x => x.ShowsId,
                        principalTable: "Showings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShowingShowroom_Showroom_ShowroomsId",
                        column: x => x.ShowroomsId,
                        principalTable: "Showroom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAccount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phonenummber = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoldseatId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAccount_Soldseat_SoldseatId",
                        column: x => x.SoldseatId,
                        principalTable: "Soldseat",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ShowingId",
                table: "Movies",
                column: "ShowingId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservedseat_ShowingId",
                table: "Reservedseat",
                column: "ShowingId");

            migrationBuilder.CreateIndex(
                name: "IX_ShowingShowroom_ShowsId",
                table: "ShowingShowroom",
                column: "ShowsId");

            migrationBuilder.CreateIndex(
                name: "IX_Soldseat_ShowingId",
                table: "Soldseat",
                column: "ShowingId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAccount_SoldseatId",
                table: "UserAccount",
                column: "SoldseatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Reservedseat");

            migrationBuilder.DropTable(
                name: "ShowingShowroom");

            migrationBuilder.DropTable(
                name: "UserAccount");

            migrationBuilder.DropTable(
                name: "Showroom");

            migrationBuilder.DropTable(
                name: "Soldseat");

            migrationBuilder.DropTable(
                name: "Showings");
        }
    }
}
