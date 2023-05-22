using EventsWebsite.Services;
using EventsWebsites.New;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using EventsWebsites.Models;
using EventsWebsite.Models;
using EventsWebsite.ViewModels;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using EventsWebsite.Data;
using EventsWebsite.Hubs;
using Microsoft.AspNetCore.SignalR;

namespace EventsWebsites.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private readonly ApplicationDbContext _context;

        //public UsersController(IUserService userService)
        //{
        //    _userService = userService;
        //}

        public UsersController(ApplicationDbContext context,
            IMapper mapper,
            IUserService userService)
        {
            _context = context;
            _mapper = mapper;
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
        public async Task<ActionResult<ApplicationUser>> GetUserById(string id)
        {
            var user = await _context.AppUsers.FindAsync(id);

            if (user == null)
                return NotFound();

            var userViewModel = _mapper.Map<ApplicationUser, UserViewModel>(user);

            return Ok(userViewModel);
        }

        //[HttpGet("{id}")]
        //public async Task<ActionResult<Room>> Get(int id)
        //{
        //    var room = await _context.Rooms.FindAsync(id);
        //    if (room == null)
        //        return NotFound();

        //    var roomViewModel = _mapper.Map<Room, RoomViewModel>(room);
        //    return Ok(roomViewModel);
        //}

        [HttpGet("swipe")]
        public IActionResult Swipe()
        {
            int id = HttpContext.Session.GetInt32("Id") ?? 0;
            var users = _userService.Swipe(id.ToString());
            return Ok(users);
        }

        //[HttpPost("updateOptions")]
        //public async Task<IActionResult> UpdateOptions(Options optionsModel)
        //{
        //    int? Id_us = HttpContext.Session.GetInt32("Id");

        //    var response = await _userService.UpdateOptions(optionsModel, Id_us.ToString());

        //    if (response == false)
        //    {
        //        return BadRequest(new { message = "Didn't edit!" });
        //    }

        //    return Ok(response);
        //}

        //[HttpGet("idOptions")]
        //public IActionResult GetOptionsId()
        //{
        //    int? id = HttpContext.Session.GetInt32("Id");

        //    if (id != null)
        //    {
        //        Console.WriteLine("Значение id из сессии: " + id);
        //        //return Ok(new { Id = id });
        //    }
        //    else
        //    {
        //        Console.WriteLine("Error");
        //        //return BadRequest("Id not found in session.");
        //    }

        //    var options = _userService.GetOptionsById((id ?? 0).ToString());

        //    if (options == null)
        //        return NotFound();

        //    return Ok(options);
        //}

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
