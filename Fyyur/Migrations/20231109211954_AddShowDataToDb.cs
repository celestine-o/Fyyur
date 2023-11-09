using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fyyur.Migrations
{
    /// <inheritdoc />
    public partial class AddShowDataToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Venues",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Venues",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Venues",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Venues",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Genre",
                table: "Venues",
                type: "int",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SocialMediaLink",
                table: "Venues",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Artists",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Artists",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Artists",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Artists",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Genre",
                table: "Artists",
                type: "int",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SocialMediaLink",
                table: "Artists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Show",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    VenueId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Show", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Show_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Show_Venues_VenueId",
                        column: x => x.VenueId,
                        principalTable: "Venues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Genre", "ImageLink", "SocialMediaLink" },
                values: new object[] { null, "https://www.bellanaija.com/wp-content/uploads/2023/06/Burna-Boy-London-Stadium-ShowDSC_5475.jpg", "Test1@twitter.com" });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Genre", "SocialMediaLink" },
                values: new object[] { null, "Test2@twitter.com" });

            migrationBuilder.CreateIndex(
                name: "IX_Show_ArtistId",
                table: "Show",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Show_VenueId",
                table: "Show",
                column: "VenueId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Show");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Venues");

            migrationBuilder.DropColumn(
                name: "SocialMediaLink",
                table: "Venues");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Artists");

            migrationBuilder.DropColumn(
                name: "SocialMediaLink",
                table: "Artists");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Venues",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Venues",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Venues",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Venues",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Artists",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Artists",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Artists",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Artists",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageLink",
                value: "https://i.guim.co.uk/img/media/dbac34d3006580e07209c8883705cdf3869d6d3a/631_2_3096_1858/master/3096.jpg");

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Address", "City", "Description", "ImageLink", "Name", "Phone", "State", "WebsiteLink" },
                values: new object[] { 2, "GRA", "Port Harcourt", "Wizkid is an Afrobeat Singer", "https://i.guim.co.uk/img/media/216a6d86592a72e2068cf60a8edc9d42256fa13f/0_272_1707_1023/master/1707.jpg", "Wiz", "23480675767", "Rivers", "www.wiz.com" });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "Address", "City", "Description", "ImageLink", "Name", "Phone", "State", "WebsiteLink" },
                values: new object[] { 2, "Ikeja City Mall", "Ikeja", "BhEERHUGZ Café is a cool place to meet up with friends and enjoy and good food, drinks and calm music without spending a lot. It is located inside the mall, surrounded by other attractions.", "https://dnbstories.com/wp-content/uploads/2021/12/sidewalk-lounge-and-bar-ikeja-50x26.jpg", "Another Spot", "23479987896", "Lagos", "www.noweb2.com" });
        }
    }
}
