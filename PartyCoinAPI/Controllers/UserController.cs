using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PartyCoinAPI.Data;
using PartyCoinAPI.Models;

namespace PartyCoinAPI.Controllers
{
  //  [Authorize]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }


        // CRUD 
        [HttpGet("GetUsers")]
        public ActionResult GetUsers()
        {
            List<ApplicationUser> users_list = _context.ApplicationUsers.ToList();
            if (users_list.Count > 0)
            {
                throw new Exception("List contains 0 elements");

            }
            return Ok(users_list);
        }
        [HttpGet("GetUser/{guid_user}")]
        public ActionResult GetUser(Guid guid_user)
        {
            ApplicationUser user = _context.ApplicationUsers.Where(g => g.guid == guid_user).First();
            if (user == null)
            {
                throw new System.ArgumentException("User not found " + guid_user);
            }
            else
            {
                return Ok(user);
            }
        }
        [HttpPost("PostUser")]
        public void PostUser([FromBody] ApplicationUser user)
        {
            if (user == null)
            {
                throw new Exception("User is empty or null try again");
            }
            else
            {

                _context.Users.Add(user);
                _context.SaveChanges();
            }
        }
        [HttpPost("PostUsers")]
        public void PostPartys([FromBody] List<ApplicationUser> users)
        {
            if (users == null)
            {
                throw new Exception("User is empty or null try again");
            }
            else
            {
                foreach (ApplicationUser u in users)
                {
                    _context.Users.Add(u);
                }

                _context.SaveChanges();
            }
        }
        [HttpPut("PostUser/{guid_user}")]
        public void PostUser(Guid guid_user, [FromBody] ApplicationUser user)
        {
            if (guid_user == null || user == null)
            {
                throw new Exception("Wrong guid or user record");
            }
            else
            {
                _context.Users.Update(user);
                _context.SaveChanges();
            }
        }
        [HttpDelete("DeleteUser/{guid_user}")]
        public void DeleteUser(Guid guid_user)
        {
            //
        }

        //[HttpPost]
        //public IActionResult Login()
        //{
        //    return Ok();
        //}

    }
}
