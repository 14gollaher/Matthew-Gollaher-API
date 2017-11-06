using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pongo.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;

namespace Pongo
{
    [Route("Pongo")]
    public class UserController : Controller
    {
        private IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("User")]
        public IActionResult GetUsers()
        {
            List<User> users;
            var response = new HttpResponseMessage(HttpStatusCode.OK);
            try
            {
                users = _userRepository.GetUsers();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return StatusCode(500);
            }
            return Ok(users);
        }

        [HttpGet("User/{userId}")]
        public IActionResult GetUser(int userId)
        {
            User user = new User();
            try
            {
                user = _userRepository.GetUser(userId);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return StatusCode(500);
            }
            return Ok(user);
        }

        [HttpPost("User")]
        public IActionResult InsertUser([FromBody] User user)
        {
            try
            {
                _userRepository.InsertUser(user);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return StatusCode(500);
            }
            return Ok(user);
        }
    }
}
