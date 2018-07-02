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
    public class CoinController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CoinController(ApplicationDbContext context)
        {
            _context = context;
        }
        // CRUD 
        [HttpGet("GetCoins")]
        public ActionResult GetCoins()
        {
            List<Coin> CoinList = _context.Coins.ToList();
            return Ok(CoinList);
        }
        [HttpGet("GetCoin/{CoinId}")]
        public ActionResult GetCoin(Guid CoinId)
        {
            Coin CoinRec = _context.Coins.Where(c => c.Id == CoinId).First();
            return Ok(CoinRec);
            
        }
        [HttpPost("PostCoin")]
        public void PostCoin([FromBody] Coin CoinRec)
        {
           _context.Coins.Add(CoinRec);
           _context.SaveChanges();
            
        }
        [HttpPost("PostCoins")]
        public void PostCoins([FromBody] List<Coin> CoinList)
        {
            foreach (Coin CoinRec in CoinList)
            {
                _context.Coins.Add(CoinRec);

            }
            _context.SaveChanges();
        }
        [HttpPut("PutCoin/{CoinId}")]
        public void PutCoin(Guid CoinId, [FromBody] Coin CoinRec)
        {
           _context.Coins.Update(CoinRec);
           _context.SaveChanges();
        }
        [HttpDelete("DeleteCoin/{CoinId}")]
        public void DeleteCoin(Guid CoinId)
        {
            //
        }
 
    }
}
