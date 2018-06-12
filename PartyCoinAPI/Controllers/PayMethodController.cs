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


        // CRUD 
        [HttpGet("GetPaymentMethods")]
        public ActionResult GetPaymentMethods()
        {
            List<PayMethod> payMethods = _context.PayMethods.ToList();
            if (payMethods.Count > 0)
            {
                throw new Exception("List contains 0 elements");

            }
            return Ok(payMethods);
        }
        [HttpGet("GetPayMethod/{guid_paymethod}")]
        public ActionResult GetPayMethod(Guid guid_paymethod)
        {
            PayMethod payMethod = _context.PayMethods.Where(p => p.guid == guid_paymethod).First();
            if (payMethod == null)
            {
                throw new System.ArgumentException("Payment method not found " + guid_paymethod);
            }
            else
            {
                return Ok(payMethod);
            }
        }
        [HttpPost("PostPaymentMethod")]
        public void PostPaymentMethod([FromBody] PayMethod payMethod)
        {
            if (payMethod == null)
            {
                throw new Exception("Paymethod is empty or null try again");
            }
            else
            {

                _context.PayMethods.Add(payMethod);
                _context.SaveChanges();
            }
        }
        [HttpPost("PostPaymentMethods")]
        public void PostPaymentMethods([FromBody] List<PayMethod> payMethods)
        {
            if (payMethods == null)
            {
                throw new Exception("PayMethod is empty or null try again");
            }
            else
            {
                foreach (PayMethod payMethod in payMethods)
                {
                    _context.PayMethods.Add(payMethod);
                }

                _context.SaveChanges();
            }
        }
        [HttpPut("PutPaymentMethod/{guid_paymethod}")]
        public void PutPaymentMethod(Guid guid_paymethod, [FromBody] PayMethod payMethod)
        {
            if (payMethod == null || guid_paymethod == null)
            {
                throw new Exception("Wrong guid or paymentmethod record");
            }
            else
            {
                _context.PayMethods.Update(payMethod);
                _context.SaveChanges();
            }
        }
        [HttpDelete("DeletePaymentMethod/{guid_paymethod}")]
        public void DeletePaymentMethod(Guid guid_paymethod)
        {
            //
        }

    }
}
