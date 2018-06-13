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
    public class TransactionController : Controller
    {
        private readonly ApplicationDbContext _context;
        public TransactionController(ApplicationDbContext context)
        {
            _context = context;
        } 
        [HttpGet("GetTransactions")]
        public ActionResult GetTransactions()
        {
            List<Transaction> TransactionList = _context.Transactions.ToList();
            return Ok(TransactionList);
        }
        [HttpGet("GetTransaction/{TransactionId}")]
        public ActionResult GetTransaction(string TransactionId)
        {
            Transaction TransactionRec = _context.Transactions.Where(t => t.Id == TransactionId).First();
            return Ok(TransactionRec);      
        }
        [HttpGet("GetTransactionsByCompany/{CmpId}")]
        public ActionResult GetTransactionsByCompany(string CmpId)
        {
            List<Transaction> TransactionList = _context.Transactions.Where(t => t.Id == CmpId).ToList();
            return Ok(TransactionList);
            
        }
        [HttpGet("GetTransactionsByParty/{PartyId}")]
        public ActionResult GetTransactionsByParty(string PartyId)
        {
            List<Transaction> TransactionList = _context.Transactions.Where(t => t.PartyId == PartyId).ToList();
            return Ok(TransactionList);
        }
        [HttpGet("GetTransactionsByPartyAndPayMethod/{PartyId}/{PayMethodId}")]
        public ActionResult GetTransactionsByPartyAndPayMethod(string PartyId, string PayMethodId)
        {
            List<Transaction> TransactionList = _context.Transactions.Where(t => t.PartyId == PartyId && t.PaymethodId == PayMethodId).ToList();
            return Ok(TransactionList);
        }
        [HttpPost("PostTransaction")]
        public void PostTransaction([FromBody] Transaction TransactionRec)
        {
            _context.Transactions.Add(TransactionRec);
            _context.SaveChanges();
        }
        [HttpPost("PostTransactions")]
        public void PostTransactions([FromBody] List<Transaction> TransactionList)
        {
            foreach (Transaction TransactionRec in TransactionList)
            {
                _context.Transactions.Add(TransactionRec);
            }

            _context.SaveChanges();
        }
        [HttpPut("PutTransaction/{TransactionId}")]
        public void PutTransaction(string TransactionId, [FromBody] Transaction TransactionRec)
        {
            _context.Transactions.Update(TransactionRec);
            _context.SaveChanges();
        }
        [HttpDelete("DelteTransaction/{TransactionId}")]
        public void DelteTransaction(string TransactionId)
        {
            //
        }
        /********************************************* Combine user & roles together**********************************/


    }
}
