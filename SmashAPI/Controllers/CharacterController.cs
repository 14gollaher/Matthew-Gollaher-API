using Microsoft.AspNetCore.Mvc;
using SmashAPI.BusinessLogic;

namespace SmashAPI
{
    [Route("/characters")]
    public class CharacterController : Controller
    {
        private ICharacterRepository _characterRepository;

        public CharacterController(ICharacterRepository characterRepository)
        {
            _characterRepository = characterRepository;
        }

        [HttpGet()]
        public IActionResult GetCharacters()
        {
            var characterEvents = _characterRepository.GetCharacters();
            return Ok(characterEvents);
        }
    }
}
