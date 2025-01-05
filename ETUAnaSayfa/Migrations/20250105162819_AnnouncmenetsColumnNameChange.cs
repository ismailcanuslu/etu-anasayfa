using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETUAnaSayfa.Migrations
{
    /// <inheritdoc />
    public partial class AnnouncmenetsColumnNameChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Announcements",
                newName: "Date");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Announcements",
                newName: "CreatedAt");
        }
    }
}
