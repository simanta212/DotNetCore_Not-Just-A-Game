using Microsoft.AspNetCore.Mvc;
using NotJustAGame.Models.DTOs.Characters;
using NotJustAGame.Service;

namespace NotJustAGame.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;
        /*private readonly ILogger<CharacterController> _logger;

        public CharacterController(ILogger<CharacterController> logger)
        {
            _logger = logger;
        }*/
        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet]
        public async Task<ActionResult<SystemResponse<List<CharacterDto>>>> Get()
        {
            var result = await _characterService.GetAllCharacters();
            return Ok(result);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<SystemResponse<CharacterDto>>> GetById(int Id)
        {
            var result = await _characterService.GetCharacter(Id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<SystemResponse<List<CharacterDto>>>> Create(CreateCharacterDto newCharacter)
        {
            var result = await _characterService.AddCharacter(newCharacter);
            return Ok(result);
        }

    }
}
