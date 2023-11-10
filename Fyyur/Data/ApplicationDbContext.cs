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
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Show> Shows { get; set; }


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
                ImageLink = "https://dnbstories.com/wp-content/uploads/2021/12/BhEERHUGZ-Cafe-768x467.jpg",
                SocialMediaLink = "Test2@twitter.com"
            }
            );

            modelBuilder.Entity<Artist>().HasData(
            new Artist
            {
                Id = 1,
                Name = "Burna",
                City = "Port Harcourt",
                State = "Rivers",
                Address = "GRA",
                Phone = "23480675767",
                WebsiteLink = "www.burna.com",
                Description = "Burna is an Afrobeat Singer",
                ImageLink = "https://www.bellanaija.com/wp-content/uploads/2023/06/Burna-Boy-London-Stadium-ShowDSC_5475.jpg",
                SocialMediaLink = "Test1@twitter.com"
            }
            );
        }

       
    }
}