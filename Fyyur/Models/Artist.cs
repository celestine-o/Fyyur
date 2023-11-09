using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Fyyur.Models
{
    public class Artist
    {
        // Use [Key to identify the primary key
        [Key]
        public int Id { get; set; }
        // Use required to identify properties that are required
        [Required]
        [DisplayName("Name")]
        [MaxLength(30)]
        public string Name { get; set; }
        [DisplayName("City")]
        [MaxLength(30)]
        public string City { get; set; }
        [DisplayName("State")]
        [MaxLength(30)]
        public string State { get; set; }
        [DisplayName("Address")]
        [MaxLength(30)]
        public string Address { get; set; }
        [DisplayName("Phone")]
        [MaxLength(30)]
        public string Phone { get; set; }
        [DisplayName("Genres")]
        [MaxLength(250)]
        public Genre? Genre  { get; set; }
        [DisplayName("Image Link")]
        public string ImageLink { get; set; }
        [DisplayName("Social Media Link")]
        public string SocialMediaLink { get; set; }
        [DisplayName("Website Link")]
        public string WebsiteLink { get; set; }
        //public string SeekingVenue { get; set; }
        [DisplayName("Description")]
        public string Description { get; set; }

        public virtual ICollection<Show> Shows { get; set;}
    }
}
