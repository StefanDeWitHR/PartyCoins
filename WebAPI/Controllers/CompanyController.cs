using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Data.Managers;
using WebAPI.Interfaces;
using WebAPI.Models;
using WebAPI.Models.DTO;

namespace WebAPI.Controllers
{
    [Authorize]
    [Route("[controller]")]
    public class CompanyController : Controller
    {
        private readonly IMapper _mapper;
        //private readonly ApplicationDbContext _context;
        private readonly IDbConnection _context;
        CompanyManger _CmpManager;
        public CompanyController(IDbConnection context , IMapper mapper , CompanyManger CmpManager)
        {
            _context = context;
            _CmpManager = CmpManager;
            _mapper = mapper;
        }
        [HttpPost("PostCompany")]
        public ActionResult PostCompany([FromBody] CompanyDTO CmpRec)
        {

            if (CmpRec == null)
            {
                return View("Error");
            }
            else
            {
                var result = _mapper.Map<Company>(CmpRec);
                _CmpManager.Add(result);
                return Ok();
            }

        }
        //[HttpGet]
        //public async Task<IActionResult> Index()
        //{
        //    return View();
        //}


        //[HttpGet("GetCompanies")]
        //public ActionResult GetCompanies()
        //{
        //    List<Company> CmpList = _context.Companies.ToList();
        //    var result = Mapper.Map<List<CompanyDTO>>(CmpList);
        //    return Ok(result);
        //}
        //[HttpGet("GetCompany/{CmpId}")]
        //public ActionResult GetCompany(Guid CmpId)
        //{ 
        //    Company CmpRec = _context.Companies.Where(g => g.Id == CmpId).First();
        //    if (CmpRec == null)
        //    {
        //        return View("Error");
        //    }
        //    else
        //    {
        //        var result = Mapper.Map<CompanyDTO>(CmpRec);
        //        return Ok(result);
        //    }
        //}

        //   [HttpPost("PostCompany")]
        //public ActionResult PostCompany([FromBody] CompanyDTO CmpRec)
        //{

        //    if(CmpRec == null)
        //    {
        //        return View("Error");
        //    }
        //    else
        //    {
        //        var result = _mapper.Map<Company>(CmpRec);
        //        _context.Companies.Add(result);
        //        _context.SaveChanges();
        //        return Ok();
        //    }

        //}
        //[HttpPost("PostCompanies")]
        //public void PostCompanies([FromBody] List<Company> CmpList)
        //{
        //    foreach (Company CmpRec in CmpList)
        //    {
        //        _context.Companies.Add(CmpRec);
        //    }
        //    _context.SaveChanges();
    }
    //[HttpPut("PutCompany/{CmpId}")]
    //public void PutCompany(string CmpId, [FromBody] Company CmpRec)
    //{
    //    _context.Companies.Update(CmpRec);
    //    _context.SaveChanges();
    //}

    //[HttpDelete("DeleteCompany/{CmpId}")]
    //public void DeleteCompany(Guid CmpId)
    //{
    //    Company CmpRec = _context.Companies.Where(c => c.Id == CmpId).FirstOrDefault();
    //    if(CmpRec != null)
    //    {
    //        _context.Companies.Remove(CmpRec);
    //        _context.SaveChanges();
    //    }
    //    else
    //    {
    //        throw new ApplicationException("Company can not be deleted");
    //    }
    //}
}
//}
