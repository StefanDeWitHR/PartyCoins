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
    [Authorize]
    [Route("[controller]")]
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
            List<ApplicationUser> UserList = _context.ApplicationUsers.ToList();
            return Ok(UserList);
        }
        [HttpGet("GetUser/{UserId}")]
        public ActionResult GetUser(string UserId)
        {
            ApplicationUser UserRec = _context.ApplicationUsers.Where(g => g.Id == UserId).First();
            return Ok(UserRec);
            
        }
        [HttpPost("PostUser")]
        public void PostUser([FromBody] ApplicationUser UserRec)
        {
            _context.Users.Add(UserRec);
            _context.SaveChanges();
        }
        [HttpPost("PostUsers")]
        public void PostPartys([FromBody] List<ApplicationUser> UserList)
        {
            foreach (ApplicationUser UserRec in UserList)
            {
                _context.Users.Add(UserRec);
            }
            _context.SaveChanges();
        }
        [HttpPut("PutUser/{UserId}")]
        public void PutUser(Guid UserId, [FromBody] ApplicationUser UserRec)
        {
            _context.Users.Update(UserRec);
            _context.SaveChanges();
        }
        [HttpDelete("DeleteUser/{UserId}")]
        public void DeleteUser(Guid UserId)
        {
            //
        }
        /********************************************* Combine user & roles together**********************************/
        

    }
}
