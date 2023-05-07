using System.ComponentModel.DataAnnotations;

namespace multitracks.API.Domain.Models.DTOs
{
    public class CreateArtistDTO
    {
        [Required]
        public string Title { get; set; }
        [Required]

        public string Biography { get; set; }
        [Required]

        public string ImageUrl { get; set; }
        [Required]

        public string HeroUrl { get; set; }
    }
}
