using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETUAnaSayfa.Migrations
{
    /// <inheritdoc />
    public partial class announcementsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isVisible",
                table: "News",
                newName: "IsVisible");

            migrationBuilder.RenameColumn(
                name: "isPinned",
                table: "News",
                newName: "IsPinned");

            migrationBuilder.RenameColumn(
                name: "isVisible",
                table: "Events",
                newName: "IsVisible");

            migrationBuilder.RenameColumn(
                name: "isPinned",
                table: "Events",
                newName: "IsPinned");

            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(1200)", maxLength: 1200, nullable: false),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false),
                    IsPinned = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Announcements");

            migrationBuilder.RenameColumn(
                name: "IsVisible",
                table: "News",
                newName: "isVisible");

            migrationBuilder.RenameColumn(
                name: "IsPinned",
                table: "News",
                newName: "isPinned");

            migrationBuilder.RenameColumn(
                name: "IsVisible",
                table: "Events",
                newName: "isVisible");

            migrationBuilder.RenameColumn(
                name: "IsPinned",
                table: "Events",
                newName: "isPinned");
        }
    }
}
