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
            List<Company> cmp_list = _context.Companies.ToList();
            if (cmp_list.Count > 0)
            {
                throw new Exception("List contains 0 elements");

            }
            return Ok(cmp_list);
        }
        [HttpGet("GetCompany/{guid_cmp}")]
        public ActionResult GetCompany(Guid guid_cmp)
        {
            Company cmp = _context.Companies.Where(g => g.guid == guid_cmp).First();
            if (cmp == null)
            {
                throw new System.ArgumentException("Company not found ");
            }
            else
            {
                return Ok(cmp);
            }
        }
        [HttpPost("PostCompany")]
        public void PostCompany([FromBody] Company cmp)
        {
            if (cmp == null)
            {
                throw new Exception("Company is empty or null try again");
            }
            else
            {

                _context.Companies.Add(cmp);
                _context.SaveChanges();
            }
        }
        [HttpPost("PostCompanies")]
        public void PostCompanies([FromBody] List<Company> cmp)
        {
            if (cmp == null)
            {
                throw new Exception("Company is empty or null try again");
            }
            else
            {
                foreach(Company c in cmp)
                {
                    _context.Companies.Add(c);
                }
                
                _context.SaveChanges();
            }
        }
        [HttpPut("PutCompany/{guid_cmp}")]
        public void PutCompany(Guid guid_cmp, [FromBody] Company cmp)
        {
            if (guid_cmp == null || cmp == null)
            {
                throw new Exception("Wrong guid or cmp records");
            }
            else
            {
                _context.Companies.Update(cmp);
                _context.SaveChanges();
            }
        }
      
        [HttpDelete("DeleteCompany/{guid_cmp}")]
        public void DeleteCompany(Guid guid_cmp)
        {
        }
    }
}
