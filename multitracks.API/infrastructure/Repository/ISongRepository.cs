using multitracks.API.Domain.Models.Entities;

namespace multitracks.API.infrastructure.Repository
{
    public interface ISongRepository
    {
        Task<List<Song>> GetAllSongsAsync(int pageNumber, int pageSize);
    }
}