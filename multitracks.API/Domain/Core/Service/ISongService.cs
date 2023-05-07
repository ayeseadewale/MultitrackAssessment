using multitracks.API.Domain.Models.DTOs;

namespace multitracks.API.Domain.Core.Service
{
    public interface ISongService
    {
        Task<List<SongDTO>> GetAllSongsAsync(int pageNumber, int pageSize);
    }
}