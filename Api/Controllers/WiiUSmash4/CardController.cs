using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WiiUSmash4.BusinessLogic;

namespace WiiUSmash4
{
    [Route("wiiusmash4/card")]
    public class CardController : Controller
    {
        private IFighterRepository _fighterRepository;

        public CardController(IFighterRepository fighterRepository)
        {
            _fighterRepository = fighterRepository;
        }

        [HttpGet("")]
        public IActionResult GetCards()
        {
            IEnumerable<Card> icons;
            try
            {
                icons = _fighterRepository.GetCards();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return StatusCode(500);

            }
            return Ok(icons);
        }
    }
}
