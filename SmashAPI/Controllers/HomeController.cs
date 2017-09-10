using Microsoft.AspNetCore.Mvc;
using WiiUSmash4.BusinessLogic;

namespace WiiUSmash4
{
    [Route("/")]
    public class HomeController : Controller
    {
        private IFighterRepository _fighterRepository;

        public HomeController(IFighterRepository fighterRepository)
        {
            _fighterRepository = fighterRepository;
        }

        [HttpGet()]
        public IActionResult Index()
        {
            return View();
        }
    }
}
