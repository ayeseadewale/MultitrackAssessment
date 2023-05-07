using AutoMapper;
using multitracks.API.Domain.Models.DTOs;
using multitracks.API.Domain.Models.Entities;
using multitracks.API.infrastructure.Repository;

namespace multitracks.API.Domain.Core.Service
{
    public class ArtistService : IArtistService
    {
        private readonly IArtistRepository artistRepository;
        private readonly IMapper mapper;

        public ArtistService(IArtistRepository artistRepository, IMapper mapper)
        {
            this.artistRepository = artistRepository;
            this.mapper = mapper;
        }

        public async Task<List<GetArtistDetailsDTO>> SearchArtistByName(string name)
        {
            var artists = await artistRepository.SearchArtistByNameAsync(name);
            return mapper.Map<List<GetArtistDetailsDTO>>(artists);
        }
        public async Task<GetArtistDetailsDTO> CreateArtistAsync(CreateArtistDTO request)
        {
            var artist = mapper.Map<Artist>(request);
            var artistCreated = await artistRepository.CreateArtistAsync(artist);
            return mapper.Map<GetArtistDetailsDTO>(artistCreated);
        }
    }
}
