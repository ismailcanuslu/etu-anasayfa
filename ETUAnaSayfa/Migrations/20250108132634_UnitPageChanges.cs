using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETUAnaSayfa.Migrations
{
    /// <inheritdoc />
    public partial class UnitPageChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UnitMainPageId",
                table: "UnitMenus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UnitMenus_UnitMainPageId",
                table: "UnitMenus",
                column: "UnitMainPageId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitMainPage_Subpath",
                table: "UnitMainPage",
                column: "Subpath",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UnitMenus_UnitMainPage_UnitMainPageId",
                table: "UnitMenus",
                column: "UnitMainPageId",
                principalTable: "UnitMainPage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UnitMenus_UnitMainPage_UnitMainPageId",
                table: "UnitMenus");

            migrationBuilder.DropIndex(
                name: "IX_UnitMenus_UnitMainPageId",
                table: "UnitMenus");

            migrationBuilder.DropIndex(
                name: "IX_UnitMainPage_Subpath",
                table: "UnitMainPage");

            migrationBuilder.DropColumn(
                name: "UnitMainPageId",
                table: "UnitMenus");
        }
    }
}
