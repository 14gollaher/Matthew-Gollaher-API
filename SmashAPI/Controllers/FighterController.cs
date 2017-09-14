using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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

        [HttpPost("")]
        public IActionResult InsertFighter()//[FromBody] Fighter fighter)
        {
            //try
            //{
            //    MockFighterRepository repo = new MockFighterRepository();
            //    Fighter fighter = repo.GetFighter(1);
            //    _fighterRepository.InsertFighter(fighter);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //    return StatusCode(500);

            //}
            return NoContent();
        }

        [HttpGet()]
        public IActionResult GetFighters()
        {
            IEnumerable<Fighter> fighters;
            try
            {
                fighters = _fighterRepository.GetFighters();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return StatusCode(500);
            }
            return Ok(fighters);
        }

        [HttpGet("{fighterId}")]
        public IActionResult GetFighter(int fighterId)
        {
            Fighter fighter = new Fighter();
            try
            {
                fighter = _fighterRepository.GetFighter(fighterId);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return StatusCode(500);
            }
            return Ok(fighter);
        }
    }
}
