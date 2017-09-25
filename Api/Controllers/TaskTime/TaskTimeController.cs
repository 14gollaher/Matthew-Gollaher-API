using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TaskTime.BusinessLogic;

namespace Api
{
    [Route("TaskTime")]
    public class TaskTimeController : Controller
    {
        private readonly TaskTimeConfiguration _configuration;

        public TaskTimeController(TaskTimeConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet()]
        public async Task<IActionResult> Index()
        {
            try
            {
                SmSNotifer notifer = new SmSNotifer(_configuration);
                await notifer.SendMessagesAsync("Mommy is a nooooob!");
                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return StatusCode(500);
            }
        }
    }
}
