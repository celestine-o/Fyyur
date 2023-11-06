using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Fyyur.Models
{
    public class Venue
    {
        // Use [Key to identify the primary key
        /*
    genres = db.Column(db.ARRAY(db.String(120)), nullable=False)
    image_link = db.Column(db.String(500))
    facebook_link = db.Column(db.String(120))
    website_link = db.Column(db.String(120))
    seeking_talent = db.Column(db.String(5))
    seeking_description = db.Column(db.String(500))
         */
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
        //public string SeekingTalent { get; set; }
        public string Description { get; set; }
    }
}
