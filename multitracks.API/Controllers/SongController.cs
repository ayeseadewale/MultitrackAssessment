using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using multitracks.API.Domain.Core.Service;

namespace multitracks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        private readonly ISongService _songService;

        public SongController(ISongService songService)
        {
            _songService = songService;
        }

        [HttpGet, Route("list")]
        public async Task<IActionResult> Get(int pageNumber, int pageSize)
        {

            var songs = await _songService.GetAllSongsAsync(pageNumber, pageSize);
            if (songs is not null)
            {
                return Ok(songs);
            }
            return BadRequest();
        }
    }
}
