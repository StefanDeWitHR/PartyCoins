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


        // CRUD 
        [HttpGet("GetTransactions")]
        public ActionResult GetTransactions()
        {
            List<Transaction> trans_list = _context.Transactions.ToList();
            if (trans_list.Count > 0)
            {
                throw new Exception("List contains 0 elements");

            }
            return Ok(trans_list);
        }
        [HttpGet("GetTransaction/{guid_transaction}")]
        public ActionResult GetTransaction(Guid guid_transaction)
        {
            Transaction trans = _context.Transactions.Where(t => t.guid == guid_transaction).First();
            if (trans == null)
            {
                throw new System.ArgumentException("Transaction not found " + trans);
            }
            else
            {
                return Ok(trans);
            }
        }
        [HttpGet("GetTransactionsByCompany/{guid_company}")]
        public ActionResult GetTransactionsByCompany(Guid guid_company)
        {
            List<Transaction> trans = _context.Transactions.Where(t => t.guid_company == guid_company).ToList();
            if (trans == null)
            {
                throw new System.ArgumentException("Transactions not found " + trans);
            }
            else
            {
                return Ok(trans);
            }
        }
        [HttpGet("GetTransactionsByParty/{guid_party}")]
        public ActionResult GetTransactionsByParty(Guid guid_party)
        {
            List<Transaction> trans = _context.Transactions.Where(t => t.guid_party == guid_party).ToList();
            if (trans == null)
            {
                throw new System.ArgumentException("Transactions not found " + trans);
            }
            else
            {
                return Ok(trans);
            }
        }
        [HttpGet("GetTransactionsByPartyAndPayMethod/{guid_party}/{guid_paymethod}")]
        public ActionResult GetTransactionsByPartyAndPayMethod(Guid guid_party , Guid guid_paymethod)
        {
            List<Transaction> trans = _context.Transactions.Where(t => t.guid_party == guid_party && t.guid_paymethod == guid_paymethod).ToList();
            if (trans == null)
            {
                throw new System.ArgumentException("Transactions not found " + trans);
            }
            else
            {
                return Ok(trans);
            }
        }
        [HttpPost("PostTransaction")]
        public void PostTransaction([FromBody] Transaction trans)
        {
            if (trans == null)
            {
                throw new Exception("Transaction is empty or null try again");
            }
            else
            {

                _context.Transactions.Add(trans);
                _context.SaveChanges();
            }
        }
        [HttpPost("PostTransactions")]
        public void PostTransactions([FromBody] List<Transaction> trans)
        {
            if (trans == null)
            {
                throw new Exception("Transactions are empty or null try again");
            }
            else
            {
                foreach (Transaction tr in trans)
                {
                    _context.Transactions.Add(tr);
                }

                _context.SaveChanges();
            }
        }
        [HttpPut("PutTransaction/{guid_transaction}")]
        public void PutTransaction(Guid guid_transaction, [FromBody] Transaction trans)
        {
            if (guid_transaction == null || trans == null)
            {
                throw new Exception("Wrong guid or transaction record");
            }
            else
            {
                _context.Transactions.Update(trans);
                _context.SaveChanges();
            }
        }
        [HttpDelete("DelteTransaction/{guid_transaction}")]
        public void DelteTransaction(Guid guid_transaction)
        {
            //
        }
        /********************************************* Combine user & roles together**********************************/


    }
}
