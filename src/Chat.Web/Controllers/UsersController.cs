using EventsWebsite.Services;
using EventsWebsites.New;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using EventsWebsites.Models;

namespace EventsWebsites.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {

        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        

        [HttpPost("update")]
        public async Task<IActionResult> UpdateInf(UserModel userModel)
        {
            int? Id_us = HttpContext.Session.GetInt32("Id");

            var response = await _userService.UpdateInformation(userModel, Id_us);

            if (response == null)
            {
                return BadRequest(new { message = "Didn't edit!" });
            }

            return Ok(response);
        }

        [HttpGet("id")]
        public IActionResult GetId()
        {
            int? id = HttpContext.Session.GetInt32("Id");

            if (id != null)
            {
                Console.WriteLine("Значение id из сессии: " + id);
                //return Ok(new { Id = id });
            }
            else
            {
                Console.WriteLine("Error");
                //return BadRequest("Id not found in session.");
            }

            var user = _userService.GetById((id ?? 0).ToString());

            if (user == null)
                return NotFound();

            return Ok(user);
        }

        [HttpGet("TakeId")]
        public IActionResult TakeId()
        {
            int? id = HttpContext.Session.GetInt32("Id");
            return Ok(id);
        }

        //[Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

        //[Authorize]
        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = _userService.GetById(id.ToString());

            if (user == null)
                return NotFound();

            return Ok(user);
        }

        [HttpGet("swipe")]
        public IActionResult Swipe()
        {
            int id = HttpContext.Session.GetInt32("Id") ?? 0;
            var users = _userService.Swipe(id.ToString());
            return Ok(users);
        }

        [HttpPost("updateOptions")]
        public async Task<IActionResult> UpdateOptions(Options optionsModel)
        {
            int? Id_us = HttpContext.Session.GetInt32("Id");

            var response = await _userService.UpdateOptions(optionsModel, Id_us.ToString());

            if (response == false)
            {
                return BadRequest(new { message = "Didn't edit!" });
            }

            return Ok(response);
        }

        [HttpGet("idOptions")]
        public IActionResult GetOptionsId()
        {
            int? id = HttpContext.Session.GetInt32("Id");

            if (id != null)
            {
                Console.WriteLine("Значение id из сессии: " + id);
                //return Ok(new { Id = id });
            }
            else
            {
                Console.WriteLine("Error");
                //return BadRequest("Id not found in session.");
            }

            var options = _userService.GetOptionsById((id ?? 0).ToString());

            if (options == null)
                return NotFound();

            return Ok(options);
        }

        [HttpPost("likes")]
        public async Task<IActionResult> Like(int id, Boolean like)
        {
            int? Id_us = HttpContext.Session.GetInt32("Id");
            var response = await _userService.Like(Id_us, id, like);

            if (response == false)
            {
                return BadRequest(new { message = "Didn't edit!" });
            }

            return Ok(response);
        }

        [HttpGet("matches")]
        public IActionResult GetMathes()
        {
            int? id = HttpContext.Session.GetInt32("Id");

            var matches = _userService.Matches((id ?? 0).ToString());

            if (matches == null)
                return NotFound();

            return Ok(matches);
        }

    }
}
