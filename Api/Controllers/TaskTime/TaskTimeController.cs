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
                SmsNotification smsNotification = new SmsNotification(_configuration);
                await smsNotification.SendMessagesAsync("Hi Kyle!");
                EmailNotification emailNotification = new EmailNotification(_configuration);
                emailNotification.SendEmail("Hello!");

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
