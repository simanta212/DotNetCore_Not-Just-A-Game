using NotJustAGame.Models.DTOs.Characters;

namespace NotJustAGame.Service
{
    public interface ICharacterService
    {
        Task<SystemResponse<List<CharacterDto>>> GetAllCharacters();
        Task<SystemResponse<CharacterDto>> GetCharacter(int id);
        Task<SystemResponse<List<CharacterDto>>> AddCharacter(CreateCharacterDto newCharacter);

    }
}
