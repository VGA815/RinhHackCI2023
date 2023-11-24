using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RinhHackServer.Models;
using System.Text.Json;

namespace RinhHackServer.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/users")]
    [ApiController]
    public class UsersController : Controller
    {
        ApplicationContext db;
        public UsersController(ApplicationContext context)
        {
            db = context;
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(string jsonModel)
        {
            var usr = JsonSerializer.Deserialize<UserModel>(jsonModel);
            var user = db.Users.FirstOrDefault(u => usr.Email == u.Email);
            if (user != null) return BadRequest();
            db.Users.Add(usr);
            await db.SaveChangesAsync();
            return StatusCode(201);
        }


        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            return Json(db.Users.ToList());
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUser(string userEmail)
        {
            if (userEmail != null)
            {
                UserModel? user = await db.Users.FirstOrDefaultAsync(p => p.Email == userEmail);
                if (user != null)
                {
                    db.Users.Remove(user);
                    await db.SaveChangesAsync();
                    return Ok();
                }
            }
            return NotFound();
        }

        [HttpPut]
        public async Task<IActionResult> EditUser(string jsonModel)
        {
            db.Users.Update(JsonSerializer.Deserialize<UserModel>(jsonModel));
            await db.SaveChangesAsync();
            return Ok();
        }
    }
}
