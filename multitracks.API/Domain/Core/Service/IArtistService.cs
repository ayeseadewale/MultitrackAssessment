using multitracks.API.Domain.Models.DTOs;

namespace multitracks.API.Domain.Core.Service
{
    public interface IArtistService
    {
        Task<GetArtistDetailsDTO> CreateArtistAsync(CreateArtistDTO artist);
        Task<List<GetArtistDetailsDTO>> SearchArtistByName(string name);
    }
}