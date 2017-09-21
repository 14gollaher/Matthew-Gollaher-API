using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WiiUSmash4.BusinessLogic;

namespace WiiUSmash4
{
    //[Route("wiiusmash4/icon")]
    [Route("/icon")]
    public class IconController : Controller
    {
        private IFighterRepository _fighterRepository;

        public IconController(IFighterRepository fighterRepository)
        {
            _fighterRepository = fighterRepository;
        }

        [HttpGet("")]
        public IActionResult GetIcons()
        {
            IEnumerable<Icon> icons;
            try
            {
                icons = _fighterRepository.GetIcons();
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
