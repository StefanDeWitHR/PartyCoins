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


        // CRUD 
        [HttpGet("GetWallets")]
        public ActionResult GetWallets()
        {
            List<Wallet> wallet_list = _context.Wallets.ToList();
            if (wallet_list.Count > 0)
            {
                throw new Exception("List contains 0 elements");

            }
            return Ok(wallet_list);
        }
        [HttpGet("GetWallet/{guid_party}/{guid_user}")]
        public ActionResult GetWallet(Guid guid_party , Guid guid_user)
        {
            Wallet wallet = _context.Wallets.Where(w => w.guid_party == guid_party && w.guid_user == guid_user).First();
            if (wallet == null)
            {
                throw new System.ArgumentException("Wallet not found " + wallet);
            }
            else
            {
                return Ok(wallet);
            }
        }
        [HttpGet("GetWalletsByUser/{guid_user}")]
        public ActionResult GetWalletsByUser(Guid guid_user)
        {
            List<Wallet> wallets = _context.Wallets.Where(w => w.guid_user == guid_user).ToList();
            if (wallets == null)
            {
                throw new System.ArgumentException("Wallet not found " + wallets);
            }
            else
            {
                return Ok(wallets);
            }
        }
        [HttpPost("PostWallet")]
        public void PostWallet([FromBody] Wallet wallet)
        {
            if (wallet == null)
            {
                throw new Exception("Wallet is empty or null try again");
            }
            else
            {

                _context.Wallets.Add(wallet);
                _context.SaveChanges();
            }
        }
        [HttpPost("PostWallets")]
        public void PostWallets([FromBody] List<Wallet> wallets)
        {
            if (wallets == null)
            {
                throw new Exception("Wallets are empty or null try again");
            }
            else
            {
                foreach (Wallet wallet in wallets)
                {
                    _context.Wallets.Add(wallet);
                }

                _context.SaveChanges();
            }
        }
        [HttpPut("PutWallet/{guid_wallet}")]
        public void PutWallet(Guid guid_wallet, [FromBody] Wallet wallet)
        {
            if (wallet == null || guid_wallet == null)
            {
                throw new Exception("Wrong guid or wallet record");
            }
            else
            {
                _context.Wallets.Update(wallet);
                _context.SaveChanges();
            }
        }
        [HttpDelete("DeleteWallet/{guid_wallet}")]
        public void DeleteWallet(Guid guid_wallet)
        {
            //
        }


    }
}
