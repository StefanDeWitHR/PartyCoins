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
            List<Coin> coins_list = _context.Coins.ToList();
            if (coins_list.Count > 0)
            {
                throw new Exception("List contains 0 elements");

            }
            return Ok(coins_list);
        }
        [HttpGet("GetCoin/{guid_coin}")]
        public ActionResult GetCoin(Guid guid_coin)
        {
            Coin coin = _context.Coins.Where(c => c.guid == guid_coin).First();
            if (coin == null)
            {
                throw new System.ArgumentException("Coin not found " + coin);
            }
            else
            {
                return Ok(coin);
            }
        }
        [HttpPost("PostCoin")]
        public void PostCoin([FromBody] Coin coin)
        {
            if (coin == null)
            {
                throw new Exception("Coin is empty or null try again");
            }
            else
            {

                _context.Coins.Add(coin);
                _context.SaveChanges();
            }
        }
        [HttpPost("PostCoins")]
        public void PostCoins([FromBody] List<Coin> coins)
        {
            if (coins == null)
            {
                throw new Exception("Coins is empty or null try again");
            }
            else
            {
                foreach (Coin coin in coins)
                {
                    _context.Coins.Add(coin);
                }

                _context.SaveChanges();
            }
        }
        [HttpPut("PutCoin/{guid_coin}")]
        public void PutCoin(Guid guid_coin, [FromBody] Coin coin)
        {
            if (coin == null || guid_coin == null)
            {
                throw new Exception("Wrong guid or coin record");
            }
            else
            {
                _context.Coins.Update(coin);
                _context.SaveChanges();
            }
        }
        [HttpDelete("DeleteCoin/{guid_coin}")]
        public void DeleteCoin(Guid guid_coin)
        {
            //
        }
 
    }
}
