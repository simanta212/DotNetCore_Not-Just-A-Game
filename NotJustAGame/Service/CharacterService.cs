using AutoMapper;
using NotJustAGame.Models.DTOs.Characters;

namespace NotJustAGame.Service

{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>()
        {
            new Character{  Id=1                  },
            new Character{  Id=2, Name = "Dipesh" },
            new Character{  Id=3, Name = "COCO" },
        };

        private readonly IMapper _mapper;

        public CharacterService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<SystemResponse<List<CharacterDto>>> AddCharacter(CreateCharacterDto newCharacter)
        {
            var systemResponse = new SystemResponse<List<CharacterDto>>();
            /*int count = characters.Count() - 1;
            int id = characters[count].Id + 1;
            newCharacter.Id = id;*/  
            //OR
            newCharacter.Id = characters.Max(x => x.Id + 1);
            //
            characters.Add(_mapper.Map<Character> (newCharacter));
            //way1
            systemResponse.Data = characters.Select(x => _mapper.Map<CharacterDto>(x)).ToList();
            return systemResponse;
        }

        public async Task<SystemResponse<List<CharacterDto>>> GetAllCharacters()
        {
            var systemResponse = new SystemResponse<List<CharacterDto>>();
            systemResponse.Data = characters.Select(x => _mapper.Map<CharacterDto>(x)).ToList();
            return systemResponse;
        }

        public async Task<SystemResponse<CharacterDto>> GetCharacter(int Id)
        {
            var systemResponse = new SystemResponse<CharacterDto>();
            var result = characters.Find(x => x.Id == Id);
            //way2
            systemResponse.Data = _mapper.Map<CharacterDto>(result);
            return systemResponse;
        }
    }
}
