using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WiiUSmash4.BusinessLogic;

namespace WiiUSmash4
{
    [Route("WiiUSmash4")]
    public class WiiUSmash4Controller : Controller
    { 
        private IFighterRepository _fighterRepository;

        public WiiUSmash4Controller(IFighterRepository fighterRepository)
        {
            _fighterRepository = fighterRepository;
        }

        [HttpGet("Card")]
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

        [HttpGet("AbilityType")]
        public IActionResult GetAbilityTypes()
        {
            IEnumerable<string> abilityTypes;
            try
            {
                abilityTypes = _fighterRepository.GetAbilityTypes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return StatusCode(500);
            }
            return Ok(abilityTypes);
        }

        [HttpGet("Fighter")]
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

        [HttpGet("Fighter/{fighterId}")]
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
