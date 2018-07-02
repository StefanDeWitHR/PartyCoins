using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PartyCoinAPI.Data;
using PartyCoinAPI.Models;
using PartyCoinAPI.Models.DTO;

namespace PartyCoinAPI.Controllers
{
    [Authorize]
    [Route("[controller]")]
    public class CompanyController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;
        public CompanyController(ApplicationDbContext context , IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View();
        }


        [HttpGet("GetCompanies")]
        public ActionResult GetCompanies()
        {
            List<Company> CmpList = _context.Companies.ToList();
            return Ok(CmpList);
        }
        [HttpGet("GetCompany/{CmpId}")]
        public ActionResult GetCompany(Guid CmpId)
        { 

            Company CmpRec = _context.Companies.Where(g => g.Id == CmpId).First();
            var TransferObject = Mapper.Map<CompanyDTO>(CmpRec);
            
            return Ok(TransferObject);
        }
        [HttpPost("PostCompany")]
        public ActionResult PostCompany([FromBody] CompanyDTO CmpRec)
        {
          
            if(CmpRec == null)
            {
                return View("Error");
            }
            else
            {
                var TransferObject = _mapper.Map<Company>(CmpRec);
                _context.Companies.Add(TransferObject);
                _context.SaveChanges();
                return Ok();
            }
                     
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
        public void DeleteCompany(Guid CmpId)
        {
            Company CmpRec = _context.Companies.Where(c => c.Id == CmpId).FirstOrDefault();
            if(CmpRec != null)
            {
                _context.Companies.Remove(CmpRec);
                _context.SaveChanges();
            }
            else
            {
                throw new ApplicationException("Company can not be deleted");
            }
        }
    }
}
