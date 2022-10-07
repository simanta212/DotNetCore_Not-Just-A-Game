namespace NotJustAGame.Service
{
    public interface ICharacterService
    {
        Task<SystemResponse<List<Character>>> GetAllCharacters();
        Task<SystemResponse<Character>> GetCharacter(int id);
        Task<SystemResponse<List<Character>>> AddCharacter(Character newCharacter);

    }
}
