using AutoMapper;
using multitracks.API.Domain.Models.DTOs;
using multitracks.API.infrastructure.Repository;

namespace multitracks.API.Domain.Core.Service
{
    public class SongService : ISongService
    {
        private readonly ISongRepository songRepository;
        private readonly IMapper mapper;

        public SongService(ISongRepository songRepository, IMapper mapper)
        {
            this.songRepository = songRepository;
            this.mapper = mapper;
        }

        public async Task<List<SongDTO>> GetAllSongsAsync(int pageNumber, int pageSize)
        {
            var songs = await songRepository.GetAllSongsAsync(pageNumber, pageSize);
            return mapper.Map<List<SongDTO>>(songs);
        }
    }
}
