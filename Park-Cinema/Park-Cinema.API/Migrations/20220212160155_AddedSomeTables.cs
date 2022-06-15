using Microsoft.EntityFrameworkCore.Migrations;

namespace Park_Cinema.API.Migrations
{
    public partial class AddedSomeTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieFormat_Formats_FormatId",
                table: "MovieFormat");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieFormat_Movies_MovieId",
                table: "MovieFormat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieFormat",
                table: "MovieFormat");

            migrationBuilder.RenameTable(
                name: "MovieFormat",
                newName: "MovieFormats");

            migrationBuilder.RenameIndex(
                name: "IX_MovieFormat_MovieId",
                table: "MovieFormats",
                newName: "IX_MovieFormats_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieFormat_FormatId",
                table: "MovieFormats",
                newName: "IX_MovieFormats_FormatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieFormats",
                table: "MovieFormats",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AdvertisingOffers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertisingOffers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvertisingOffers_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Campaigns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaigns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Campaigns_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkingHour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OurAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Lasers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoverImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lasers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lasers_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Rules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rules_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "VIPs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoverImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VIPs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VIPs_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdvertisingOffers_LanguageId",
                table: "AdvertisingOffers",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Campaigns_LanguageId",
                table: "Campaigns",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_BranchId",
                table: "Contacts",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Lasers_LanguageId",
                table: "Lasers",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Rules_LanguageId",
                table: "Rules",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_VIPs_LanguageId",
                table: "VIPs",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieFormats_Formats_FormatId",
                table: "MovieFormats",
                column: "FormatId",
                principalTable: "Formats",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieFormats_Movies_MovieId",
                table: "MovieFormats",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieFormats_Formats_FormatId",
                table: "MovieFormats");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieFormats_Movies_MovieId",
                table: "MovieFormats");

            migrationBuilder.DropTable(
                name: "AdvertisingOffers");

            migrationBuilder.DropTable(
                name: "Campaigns");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Lasers");

            migrationBuilder.DropTable(
                name: "Rules");

            migrationBuilder.DropTable(
                name: "VIPs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieFormats",
                table: "MovieFormats");

            migrationBuilder.RenameTable(
                name: "MovieFormats",
                newName: "MovieFormat");

            migrationBuilder.RenameIndex(
                name: "IX_MovieFormats_MovieId",
                table: "MovieFormat",
                newName: "IX_MovieFormat_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieFormats_FormatId",
                table: "MovieFormat",
                newName: "IX_MovieFormat_FormatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieFormat",
                table: "MovieFormat",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieFormat_Formats_FormatId",
                table: "MovieFormat",
                column: "FormatId",
                principalTable: "Formats",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieFormat_Movies_MovieId",
                table: "MovieFormat",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
