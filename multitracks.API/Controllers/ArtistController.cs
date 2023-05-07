using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using multitracks.API.Domain.Core.Service;
using multitracks.API.Domain.Models.DTOs;

namespace multitracks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        private readonly IArtistService _artistService;

        public ArtistController(IArtistService artistService)
        {
            _artistService = artistService;
        }

        [HttpGet("search/{name}", Name = "search")]
        public async Task<IActionResult> Search(string name)
        {
            var artist = await _artistService.SearchArtistByName(name);
            if (artist is not null)
            {

                return Ok(artist);

            }
            return NotFound();
        }
        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add(CreateArtistDTO request)
        {
            var artist = await _artistService.CreateArtistAsync(request);
            return CreatedAtRoute("search", new { name = artist.Title }, artist);
        }
    }
}
