using Microsoft.AspNetCore.Mvc;
using WiiUSmash4.BusinessLogic;

namespace WiiUSmash4
{
    [Route("/fighter")]
    public class FighterController : Controller
    { 
        private IFighterRepository _fighterRepository;

        public FighterController(IFighterRepository fighterRepository)
        {
            _fighterRepository = fighterRepository;
        }

        [HttpGet()]
        public IActionResult GetFighters()
        {
            var Fighters = _fighterRepository.GetFighters();
            return Ok(Fighters);
        }

        [HttpGet("{fighterId}")]
        public IActionResult GetFighter(int fighterId)
        {
            var Fighter = _fighterRepository.GetFighter(fighterId);
            return Ok(Fighter);
        }
    }
}
