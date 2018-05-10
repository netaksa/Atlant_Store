using System.ComponentModel.DataAnnotations;

namespace Atlant_Store.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}