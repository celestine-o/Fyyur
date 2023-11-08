using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fyyur.Migrations
{
    /// <inheritdoc />
    public partial class AddwizArtistDataToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Address", "City", "Description", "ImageLink", "Name", "Phone", "State", "WebsiteLink" },
                values: new object[] { 2, "GRA", "Port Harcourt", "Wizkid is an Afrobeat Singer", "https://i.guim.co.uk/img/media/216a6d86592a72e2068cf60a8edc9d42256fa13f/0_272_1707_1023/master/1707.jpg", "Wiz", "23480675767", "Rivers", "www.wiz.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
