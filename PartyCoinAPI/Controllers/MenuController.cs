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


        // CRUD 
        [HttpGet("GetMenus")]
        public ActionResult GetMenus()
        {
            List<Menu> menus = _context.Menus.ToList();
            if (menus.Count > 0)
            {
                throw new Exception("List contains 0 elements");

            }
            return Ok(menus);
        }
        [HttpGet("GetMenu/{guid_menu}")]
        public ActionResult GetMenu(Guid guid_menu)
        {
            Menu menu = _context.Menus.Where(m => m.guid== guid_menu).First();
            if (menu == null)
            {
                throw new System.ArgumentException("Menu not found " + guid_menu);
            }
            else
            {
                return Ok(menu);
            }
        }
        [HttpPost("PostMenu")]
        public void PostMenu([FromBody] Menu menu)
        {
            if (menu == null)
            {
                throw new Exception("Menu is empty or null try again");
            }
            else
            {

                _context.Menus.Add(menu);
                _context.SaveChanges();
            }
        }
        [HttpPost("PostMenus")]
        public void PostMenus([FromBody] List<Menu> menus)
        {
            if (menus == null)
            {
                throw new Exception("Menus is empty or null try again");
            }
            else
            {
                foreach (Menu menu in menus)
                {
                    _context.Menus.Add(menu);
                }

                _context.SaveChanges();
            }
        }
        [HttpPut("PutMenu/{guid_menu}")]
        public void PutMenu(Guid guid_menu, [FromBody] Menu menu)
        {
            if (menu == null || guid_menu == null)
            {
                throw new Exception("Wrong guid or menu record");
            }
            else
            {
                _context.Menus.Update(menu);
                _context.SaveChanges();
            }
        }
        [HttpDelete("DeleteMenu/{guid_menu}")]
        public void DeleteMenu(Guid guid_menu )
        {
            //
        }

    }
}
