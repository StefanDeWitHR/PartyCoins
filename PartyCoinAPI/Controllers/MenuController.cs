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
    public class MenuController : Controller
    {
        private readonly ApplicationDbContext _context;
        public MenuController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("GetMenus")]
        public ActionResult GetMenus()
        {
            List<Menu> MenuList = _context.Menus.ToList(); 
            return Ok(MenuList);
        }
        [HttpGet("GetMenu/{MenuId}")]
        public ActionResult GetMenu(Guid MenuId)
        {
            Menu MenuRec = _context.Menus.Where(m => m.Id== MenuId).First();
            return Ok(MenuRec);
        }
        [HttpPost("PostMenu")]
        public void PostMenu([FromBody] Menu MenuRec)
        {
            _context.Menus.Add(MenuRec);
            _context.SaveChanges();
        }
        [HttpPost("PostMenus")]
        public void PostMenus([FromBody] List<Menu> MenuList)
        {
            foreach (Menu MenuRec in MenuList)
            {
                _context.Menus.Add(MenuRec);
            }
            _context.SaveChanges();
        }
        [HttpPut("PutMenu/{MenuId}")]
        public void PutMenu(Guid MenuId, [FromBody] Menu MenuRec)
        {
            _context.Menus.Update(MenuRec);
            _context.SaveChanges();
        }
        [HttpDelete("DeleteMenu/{MenuId}")]
        public void DeleteMenu(Guid MenuId)
        {
            //
        }

    }
}
