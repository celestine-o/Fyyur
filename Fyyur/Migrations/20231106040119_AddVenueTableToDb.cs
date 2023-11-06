using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fyyur.Migrations
{
    /// <inheritdoc />
    public partial class AddVenueTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Venues",
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
                    table.PrimaryKey("PK_Venues", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "Address", "City", "Description", "ImageLink", "Name", "Phone", "State", "WebsiteLink" },
                values: new object[,]
                {
                    { 1, "Ikeja City Mall", "Ikeja", "BhEERHUGZ Café is a cool place to meet up with friends and enjoy and good food, drinks and calm music without spending a lot. It is located inside the mall, surrounded by other attractions.", "https://dnbstories.com/wp-content/uploads/2021/12/BhEERHUGZ-Cafe-768x467.jpg", "BhEERHUGZ Café", "23480675767", "Lagos", "www.noweb.com" },
                    { 2, "Ikeja City Mall", "Ikeja", "BhEERHUGZ Café is a cool place to meet up with friends and enjoy and good food, drinks and calm music without spending a lot. It is located inside the mall, surrounded by other attractions.", "https://dnbstories.com/wp-content/uploads/2021/12/sidewalk-lounge-and-bar-ikeja-50x26.jpg", "Another Spot", "23479987896", "Lagos", "www.noweb2.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Venues");
        }
    }
}
