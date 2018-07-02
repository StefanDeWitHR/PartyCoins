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
    [Route("[controller]")]
    public class PayMethodController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PayMethodController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("GetPaymentMethods")]
        public ActionResult GetPaymentMethods()
        {
            List<PayMethod> PayMethodList = _context.PayMethods.ToList();
            return Ok(PayMethodList);
        }
        [HttpGet("GetPayMethod/{PayMethodId}")]
        public ActionResult GetPayMethod(Guid PayMethodId)
        {
            PayMethod PayMethodRec = _context.PayMethods.Where(p => p.Id == PayMethodId).First();
            return Ok(PayMethodRec);
            
        }
        [HttpPost("PostPaymentMethod")]
        public void PostPaymentMethod([FromBody] PayMethod PayMethodRec)
        {
            _context.PayMethods.Add(PayMethodRec);
            _context.SaveChanges();
        }
        [HttpPost("PostPaymentMethods")]
        public void PostPaymentMethods([FromBody] List<PayMethod> PayMethodList)
        {
            foreach (PayMethod PayMethodRec in PayMethodList)
            {
                _context.PayMethods.Add(PayMethodRec);
            }
            _context.SaveChanges();
        }
        [HttpPut("PutPaymentMethod/{PayMethodId}")]
        public void PutPaymentMethod(Guid PayMethodId, [FromBody] PayMethod PayMethodRec)
        { 
            _context.PayMethods.Update(PayMethodRec);
            _context.SaveChanges();
        }
        [HttpDelete("DeletePaymentMethod/{PayMethodId}")]
        public void DeletePaymentMethod(Guid PayMethodId)
        {
            //
        }

    }
}
