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
    public class CompanyController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CompanyController(ApplicationDbContext context)
        {
            _context = context;
        }


  
        [HttpGet("GetCompanies")]
        public ActionResult GetCompanies()
        {
            List<Company> CmpList = _context.Companies.ToList();
            return Ok(CmpList);
        }
        [HttpGet("GetCompany/{CmpId}")]
        public ActionResult GetCompany(string CmpId)
        {
            Company CmpRec = _context.Companies.Where(g => g.Id == CmpId).First();
            return Ok(CmpRec);
        }
        [HttpPost("PostCompany")]
        public void PostCompany([FromBody] Company CmpRec)
        {
           _context.Companies.Add(CmpRec);
            _context.SaveChanges();           
        }
        [HttpPost("PostCompanies")]
        public void PostCompanies([FromBody] List<Company> CmpList)
        {
            foreach (Company CmpRec in CmpList)
            {
                _context.Companies.Add(CmpRec);
            }
            _context.SaveChanges();
        }
        [HttpPut("PutCompany/{CmpId}")]
        public void PutCompany(string CmpId, [FromBody] Company CmpRec)
        {
            _context.Companies.Update(CmpRec);
            _context.SaveChanges();
        }
      
        [HttpDelete("DeleteCompany/{CmpId}")]
        public void DeleteCompany(string CmpId)
        {
        }
    }
}
