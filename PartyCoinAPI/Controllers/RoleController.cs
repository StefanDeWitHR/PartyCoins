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
    public class RoleController : Controller
    {
        private readonly ApplicationDbContext _context;
        public RoleController(ApplicationDbContext context)
        {
            _context = context;
        }


        // CRUD 
        [HttpGet("GetRoles")]
        public ActionResult GetRoles()
        {
            List<UserRoles> user_roles = _context.AspNetRoles.ToList();
            if (user_roles.Count > 0)
            {
                throw new Exception("List contains 0 elements");

            }
            return Ok(user_roles);
        }
        [HttpGet("GetRole/{Id}")]
        public ActionResult GetRole(string Id)
        {
            UserRoles role = _context.AspNetRoles.Where(g => g.Id == Id).First();
            if (role == null)
            {
                throw new System.ArgumentException("Role not found " + Id);
            }
            else
            {
                return Ok(role);
            }
        }
        [HttpPost("PostRole")]
        public void PostRole([FromBody] UserRoles userRole)
        {
            if (userRole == null)
            {
                throw new Exception("User is empty or null try again");
            }
            else
            {

                _context.AspNetRoles.Add(userRole);
                _context.SaveChanges();
            }
        }
        [HttpPost("PostRoles")]
        public void PostRoles([FromBody] List<UserRoles> userRoles)
        {
            if (userRoles == null)
            {
                throw new Exception("UserRole is empty or null try again");
            }
            else
            {
                foreach (UserRoles usrRole in userRoles)
                {
                    _context.AspNetRoles.Add(usrRole);
                }

                _context.SaveChanges();
            }
        }
        [HttpPut("PutRole/{Id}")]
        public void PutRole(string Id, [FromBody] UserRoles UsrRole)
        {
            if (Id == null || UsrRole == null)
            {
                throw new Exception("Wrong guid or user record");
            }
            else
            {
                _context.AspNetRoles.Update(UsrRole);
                _context.SaveChanges();
            }
        }
        [HttpDelete("DeleteRole/{Id}")]
        public void DeleteRole(string Id)
        {
            //
        }

    }
}
