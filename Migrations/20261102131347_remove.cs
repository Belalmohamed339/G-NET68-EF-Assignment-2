using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace G_NET68_EF_Assignment_2.Migrations
{
    /// <inheritdoc />
    public partial class remove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendees_Badges_BadgeId",
                table: "Attendees");

            migrationBuilder.DropIndex(
                name: "IX_Attendees_BadgeId",
                table: "Attendees");

            migrationBuilder.DropColumn(
                name: "BadgeId",
                table: "Attendees");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BadgeId",
                table: "Attendees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Attendees_BadgeId",
                table: "Attendees",
                column: "BadgeId",
                unique: true,
                filter: "[BadgeId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendees_Badges_BadgeId",
                table: "Attendees",
                column: "BadgeId",
                principalTable: "Badges",
                principalColumn: "BadgeId");
        }
    }
}
