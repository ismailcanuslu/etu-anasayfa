using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETUAnaSayfa.Migrations
{
    /// <inheritdoc />
    public partial class fixUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "UnitSubMenus",
                type: "nvarchar(700)",
                maxLength: 700,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "UnitSubMenus");
        }
    }
}
