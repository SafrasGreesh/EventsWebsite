using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AutoMapper;
using EventsWebsite.Data;
using EventsWebsite.Helpers;
using EventsWebsite.Hubs;
using EventsWebsite.Models;
using EventsWebsite.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using EventsWebsite.Models;
using EventsWebsite.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EventsWebsite.Helpers;
using Microsoft.AspNetCore.Http;
using EventsWebsites.Entity;
//using EventsWebsite.Entity;

namespace EventsWebsite.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IHubContext<ApllicationUser> _hubContext;
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        //[HttpPost("authenticate")]
        //public IActionResult Authenticate(AuthenticateRequest model)
        //{
        //    var response = _userService.Authenticate(model);

        //    if (response == null)
        //        return BadRequest(new { message = "Username or password is incorrect" });


        //    HttpContext.Session.SetInt32("Id", response.Id ?? 0); //!
        //                                                          // Получение значения переменной из сессии
           


        //    return Ok(response);
        //}

        //[HttpPost("register")]
        //public async Task<IActionResult> Register(AppUsers userModel)
        //{
        //    var response = await _userService.Register(userModel);

        //    if (response == null)
        //    {
        //        return BadRequest(new { message = "Didn't register!" });
        //    }

        //    return Ok(response); 
        //}

        [HttpPost("update")]
        public async Task<IActionResult> UpdateInf(ApplicationUser userModel)
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

            var user = _userService.GetById(id ?? 0);

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
            var user = _userService.GetById(id);

            if (user == null)
                return NotFound();

            return Ok(user);
        }

        [HttpGet("swipe")]
        public IActionResult Swipe()
        {
            int id = HttpContext.Session.GetInt32("Id") ?? 0;
            var users = _userService.Swipe(id);
            return Ok(users);
        }

        [HttpPost("updateOptions")]
        public async Task<IActionResult> UpdateOptions(Options optionsModel)
        {
            int? Id_us = HttpContext.Session.GetInt32("Id");

            var response = await _userService.UpdateOptions(optionsModel, Id_us);

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

            var options = _userService.GetOptionsById(id ?? 0);

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

            var matches = _userService.Matches(id ?? 0);

            if (matches == null)
                return NotFound();

            return Ok(matches);
        }

    }
}
