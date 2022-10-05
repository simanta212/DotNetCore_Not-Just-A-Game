using Microsoft.AspNetCore.Mvc;

namespace NotJustAGame.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {

        /*private readonly ILogger<CharacterController> _logger;

        public CharacterController(ILogger<CharacterController> logger)
        {
            _logger = logger;
        }*/
        private static List<Character> characters = new List<Character>()
        {
            new Character{  Id=1                  },
            new Character{  Id=2, Name = "Dipesh" },
            new Character{  Id=3, Name = "Simran" },
        };

        [HttpGet]
        public ActionResult<List<Character>> Get()
        {
            return Ok(characters);
        }
        [HttpGet("{Id}")]
        public ActionResult<List<Character>> GetById(int Id)
        {
            var result = characters.FindAll(x => x.Id == Id).ToList();
            return Ok(result);
        }
    }
}
