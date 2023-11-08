using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fyyur.Migrations
{
    /// <inheritdoc />
    public partial class AddArtistDataToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebsiteLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Artist",
                columns: new[] { "Id", "Address", "City", "Description", "ImageLink", "Name", "Phone", "State", "WebsiteLink" },
                values: new object[] { 1, "GRA", "Port Harcourt", "Burna is an Afrobeat Singer", "https://i.guim.co.uk/img/media/dbac34d3006580e07209c8883705cdf3869d6d3a/631_2_3096_1858/master/3096.jpg", "Burna", "23480675767", "Rivers", "www.burna.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artist");
        }
    }
}
