using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SmashAPI.BusinessLogic;

namespace SmashAPI
{
    [Route("[controller]")]
    public class CharacterController : Controller
    {
        private ICharacterRepository _characterRepository;

        public CharacterController(ICharacterRepository characterRepository)
        {
            _characterRepository = characterRepository;
        }

        [HttpGet()]
        public IActionResult Get()
        {
            var characterEvents = _characterRepository.GetCharacters();
            return Ok(characterEvents);
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
