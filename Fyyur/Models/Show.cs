using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Fyyur.Models
{
    public class Show
    {
        public int Id { get; set; }
        public string StartTime { get; set; }
        public int ArtistId { get; set; }
        public int VenueId { get; set; }

        public virtual Venue Venue { get; set; }
        public virtual Artist Artist { get; set; }
    }
}
