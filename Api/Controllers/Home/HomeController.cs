using Microsoft.AspNetCore.Mvc;

namespace Api
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
