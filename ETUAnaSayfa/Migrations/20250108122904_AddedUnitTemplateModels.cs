using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETUAnaSayfa.Migrations
{
    /// <inheritdoc />
    public partial class AddedUnitTemplateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UnitMainPage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subpath = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitMainPage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitMenus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IconPath = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitMenus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitAnnouncements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(1200)", maxLength: 1200, nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false),
                    IsPinned = table.Column<bool>(type: "bit", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UnitMainPageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitAnnouncements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnitAnnouncements_UnitMainPage_UnitMainPageId",
                        column: x => x.UnitMainPageId,
                        principalTable: "UnitMainPage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnitPublications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(1200)", maxLength: 1200, nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false),
                    IsPinned = table.Column<bool>(type: "bit", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UnitMainPageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitPublications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnitPublications_UnitMainPage_UnitMainPageId",
                        column: x => x.UnitMainPageId,
                        principalTable: "UnitMainPage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnitQuickAccess",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    ActionURI = table.Column<string>(type: "nvarchar(700)", maxLength: 700, nullable: false),
                    MainPageId = table.Column<int>(type: "int", nullable: false),
                    UnitMainPageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitQuickAccess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnitQuickAccess_UnitMainPage_UnitMainPageId",
                        column: x => x.UnitMainPageId,
                        principalTable: "UnitMainPage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnitSubMenus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(3550)", maxLength: 3550, nullable: true),
                    Link = table.Column<string>(type: "nvarchar(700)", maxLength: 700, nullable: true),
                    UnitMenusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitSubMenus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnitSubMenus_UnitMenus_UnitMenusId",
                        column: x => x.UnitMenusId,
                        principalTable: "UnitMenus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UnitAnnouncements_UnitMainPageId",
                table: "UnitAnnouncements",
                column: "UnitMainPageId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitPublications_UnitMainPageId",
                table: "UnitPublications",
                column: "UnitMainPageId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitQuickAccess_UnitMainPageId",
                table: "UnitQuickAccess",
                column: "UnitMainPageId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitSubMenus_UnitMenusId",
                table: "UnitSubMenus",
                column: "UnitMenusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UnitAnnouncements");

            migrationBuilder.DropTable(
                name: "UnitPublications");

            migrationBuilder.DropTable(
                name: "UnitQuickAccess");

            migrationBuilder.DropTable(
                name: "UnitSubMenus");

            migrationBuilder.DropTable(
                name: "UnitMainPage");

            migrationBuilder.DropTable(
                name: "UnitMenus");
        }
    }
}
