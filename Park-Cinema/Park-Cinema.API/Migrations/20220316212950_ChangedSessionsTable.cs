using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Park_Cinema.API.Migrations
{
    public partial class ChangedSessionsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Halls_HallId",
                table: "Seats");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_SessionTimes_SessionTimeId",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "TypeSessionTimePrices");

            migrationBuilder.DropTable(
                name: "SessionTimes");

            migrationBuilder.RenameColumn(
                name: "SessionTimeId",
                table: "Tickets",
                newName: "SessionId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_SessionTimeId",
                table: "Tickets",
                newName: "IX_Tickets_SessionId");

            migrationBuilder.RenameColumn(
                name: "HallId",
                table: "Seats",
                newName: "SessionId");

            migrationBuilder.RenameIndex(
                name: "IX_Seats_HallId",
                table: "Seats",
                newName: "IX_Seats_SessionId");

            migrationBuilder.CreateTable(
                name: "SessionPrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionId = table.Column<int>(type: "int", nullable: false),
                    PriceType = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionPrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SessionPrices_Sessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "Sessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SessionPrices_SessionId",
                table: "SessionPrices",
                column: "SessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Sessions_SessionId",
                table: "Seats",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Sessions_SessionId",
                table: "Tickets",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Sessions_SessionId",
                table: "Seats");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Sessions_SessionId",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "SessionPrices");

            migrationBuilder.RenameColumn(
                name: "SessionId",
                table: "Tickets",
                newName: "SessionTimeId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_SessionId",
                table: "Tickets",
                newName: "IX_Tickets_SessionTimeId");

            migrationBuilder.RenameColumn(
                name: "SessionId",
                table: "Seats",
                newName: "HallId");

            migrationBuilder.RenameIndex(
                name: "IX_Seats_SessionId",
                table: "Seats",
                newName: "IX_Seats_HallId");

            migrationBuilder.CreateTable(
                name: "SessionTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionId = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<TimeSpan>(type: "time", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionTimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SessionTimes_Sessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "Sessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TypeSessionTimePrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    PriceType = table.Column<int>(type: "int", nullable: false),
                    SessionTimeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeSessionTimePrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TypeSessionTimePrices_SessionTimes_SessionTimeId",
                        column: x => x.SessionTimeId,
                        principalTable: "SessionTimes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SessionTimes_SessionId",
                table: "SessionTimes",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeSessionTimePrices_SessionTimeId",
                table: "TypeSessionTimePrices",
                column: "SessionTimeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Halls_HallId",
                table: "Seats",
                column: "HallId",
                principalTable: "Halls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_SessionTimes_SessionTimeId",
                table: "Tickets",
                column: "SessionTimeId",
                principalTable: "SessionTimes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
