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
        [HttpGet("GetRoles")]
        public ActionResult GetRoles()
        {
            List<UserRoles> UserRoleList = _context.AspNetRoles.ToList();
            return Ok(UserRoleList);
        }
        [HttpGet("GetRole/{UserRoleId}")]
        public ActionResult GetRole(string UserRoleId)
        {
           UserRoles UserRoleRec = _context.AspNetRoles.Where(g => g.Id == UserRoleId).First();
           return Ok(UserRoleRec); 
        }
        [HttpPost("PostRole")]
        public void PostRole([FromBody] UserRoles UserRoleRec)
        {
            _context.AspNetRoles.Add(UserRoleRec);
            _context.SaveChanges();
        }
        [HttpPost("PostRoles")]
        public void PostRoles([FromBody] List<UserRoles> UserRoleList)
        {
            foreach (UserRoles UserRoleRec in UserRoleList)
            {
                _context.AspNetRoles.Add(UserRoleRec);
            }
            _context.SaveChanges();
        }
        [HttpPut("PutRole/{UserRoleId}")]
        public void PutRole(string UserRoleId, [FromBody] UserRoles UserRoleRec)
        {
            _context.AspNetRoles.Update(UserRoleRec);
            _context.SaveChanges();
        }
        [HttpDelete("DeleteRole/{UserRoleId}")]
        public void DeleteRole(string UserRoleId)
        {
            //
        }

    }
}
