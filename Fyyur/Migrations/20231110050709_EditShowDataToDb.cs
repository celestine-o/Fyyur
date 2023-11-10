using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fyyur.Migrations
{
    /// <inheritdoc />
    public partial class EditShowDataToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Show_Artists_ArtistId",
                table: "Show");

            migrationBuilder.DropForeignKey(
                name: "FK_Show_Venues_VenueId",
                table: "Show");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Show",
                table: "Show");

            migrationBuilder.RenameTable(
                name: "Show",
                newName: "Shows");

            migrationBuilder.RenameIndex(
                name: "IX_Show_VenueId",
                table: "Shows",
                newName: "IX_Shows_VenueId");

            migrationBuilder.RenameIndex(
                name: "IX_Show_ArtistId",
                table: "Shows",
                newName: "IX_Shows_ArtistId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shows",
                table: "Shows",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shows_Artists_ArtistId",
                table: "Shows",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shows_Venues_VenueId",
                table: "Shows",
                column: "VenueId",
                principalTable: "Venues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shows_Artists_ArtistId",
                table: "Shows");

            migrationBuilder.DropForeignKey(
                name: "FK_Shows_Venues_VenueId",
                table: "Shows");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shows",
                table: "Shows");

            migrationBuilder.RenameTable(
                name: "Shows",
                newName: "Show");

            migrationBuilder.RenameIndex(
                name: "IX_Shows_VenueId",
                table: "Show",
                newName: "IX_Show_VenueId");

            migrationBuilder.RenameIndex(
                name: "IX_Shows_ArtistId",
                table: "Show",
                newName: "IX_Show_ArtistId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Show",
                table: "Show",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Show_Artists_ArtistId",
                table: "Show",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Show_Venues_VenueId",
                table: "Show",
                column: "VenueId",
                principalTable: "Venues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
