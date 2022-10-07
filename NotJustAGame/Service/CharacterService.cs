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
        public async Task<SystemResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
            var systemResponse = new SystemResponse<List<Character>>();
            characters.Add(newCharacter);
            systemResponse.Data = characters;
            return systemResponse;
        }

        public async Task<SystemResponse<List<Character>>> GetAllCharacters()
        {
            var systemResponse = new SystemResponse<List<Character>>();
            systemResponse.Data = characters;
            return systemResponse;
        }

        public async Task<SystemResponse<Character>> GetCharacter(int Id)
        {
            var systemResponse = new SystemResponse<Character>();
            systemResponse.Data = characters.Find(x => x.Id == Id);
            return systemResponse;
        }
    }
}
