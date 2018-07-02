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
    public class WalletController : Controller
    {
        private readonly ApplicationDbContext _context;
        public WalletController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("GetWallets")]
        public ActionResult GetWallets()
        {
            List<Wallet> WalletList = _context.Wallets.ToList();
            return Ok(WalletList);
        }
        [HttpGet("GetWallet/{UserId}")]
        public ActionResult GetWallet( Guid UserId)
        {
            Wallet WalletRec = _context.Wallets.Where(w => w.UserId  == UserId).First();
            return Ok(WalletRec);
        }
        [HttpGet("GetWalletsByUser/{UserId}")]
        public ActionResult GetWalletsByUser(Guid UserId)
        {
            List<Wallet> WalletList = _context.Wallets.Where(w => w.UserId == UserId).ToList();
            return Ok(WalletList);
            
        }
        [HttpPost("PostWallet")]
        public void PostWallet([FromBody] Wallet WalletRec)
        {
            _context.Wallets.Add(WalletRec);
            _context.SaveChanges();
        }
        [HttpPost("PostWallets")]
        public void PostWallets([FromBody] List<Wallet> WalletList)
        {
            foreach (Wallet WalletRec in WalletList)
            {
                _context.Wallets.Add(WalletRec);
            }
            _context.SaveChanges();
        }
        [HttpPut("PutWallet/{WalletId}")]
        public void PutWallet(string WalletId, [FromBody] Wallet WalletRec)
        {
           
          _context.Wallets.Update(WalletRec);
          _context.SaveChanges();
            
        }
        [HttpDelete("DeleteWallet/{WalletId}")]
        public void DeleteWallet(string WalletId)
        {
            //
        }


    }
}
