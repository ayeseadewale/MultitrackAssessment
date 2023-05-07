using multitracks.API.Domain.Models.DTOs;
using multitracks.API.Domain.Models.Entities;

namespace multitracks.API.infrastructure.Repository
{
    public interface IArtistRepository
    {
        Task<Artist> CreateArtistAsync(Artist artist);
        Task<List<Artist>> SearchArtistByNameAsync(string name);
    }
}