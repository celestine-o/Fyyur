using Fyyur.Models;
using Microsoft.EntityFrameworkCore;

namespace Fyyur.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<Venue> Venues { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Venue>().HasData(
            new Venue
            {
                Id = 1,
                Name = "BhEERHUGZ Café",
                City = "Ikeja",
                State = "Lagos",
                Address = "Ikeja City Mall",
                Phone = "23480675767",
                WebsiteLink = "www.noweb.com",
                Description = "BhEERHUGZ Café is a cool place to meet up with friends and enjoy and good food, drinks and calm music without spending a lot. It is located inside the mall, surrounded by other attractions.",
                ImageLink = "https://dnbstories.com/wp-content/uploads/2021/12/BhEERHUGZ-Cafe-768x467.jpg"
            },
            new Venue
            {
                Id = 2,
                Name = "Another Spot",
                City = "Ikeja",
                State = "Lagos",
                Address = "Ikeja City Mall",
                Phone = "23479987896",
                WebsiteLink = "www.noweb2.com",
                Description = "BhEERHUGZ Café is a cool place to meet up with friends and enjoy and good food, drinks and calm music without spending a lot. It is located inside the mall, surrounded by other attractions.",
                ImageLink = "https://dnbstories.com/wp-content/uploads/2021/12/sidewalk-lounge-and-bar-ikeja-50x26.jpg"
            }
            );
        }
    }
}