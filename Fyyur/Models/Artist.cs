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
        public string City { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        //public string[] Genres  { get; set; }
        public string ImageLink { get; set; }
        //public string[] SocialMediaLink { get; set; }
        public string WebsiteLink { get; set; }
        //public string SeekingVenue { get; set; }
        public string Description { get; set; }
    }
}
