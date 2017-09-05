using Microsoft.AspNetCore.Mvc;
using SmashAPI.BusinessLogic;

namespace SmashAPI
{
    [Route("/Fighters")]
    public class FighterController : Controller
    {
        private IFighterRepository _FighterRepository;

        public FighterController(IFighterRepository FighterRepository)
        {
            _FighterRepository = FighterRepository;
        }

        [HttpGet()]
        public IActionResult GetFighters()
        {
            var FighterEvents = _FighterRepository.GetFighters();
            return Ok(FighterEvents);
        }
    }
}
