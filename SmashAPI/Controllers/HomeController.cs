using Microsoft.AspNetCore.Mvc;

namespace MatthewGollaher
{
    [Route("/")]
    public class HomeController : Controller
    {
        [HttpGet()]
        public IActionResult Index()
        {
            return View();
        }
    }
}
