//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using PartyCoinAPI.Data;
//using PartyCoinAPI.Models;

//namespace PartyCoinAPI.Controllers
//{
//    [Authorize]
//    [Route("[controller]")]
//    public class CoinController : Controller
//    {
//        private readonly IDbConnection _context;
//        public CoinController(IDbConnection context)
//        {

//            _context = context;
//        }
//        // CRUD 
//        [HttpGet("GetCoins")]
//        public ActionResult GetCoins()
//        {
//            List<Coin> CoinList = _context.Coins.ToList();
//            return Ok(CoinList);
//        }
//        [HttpGet("GetCoin/{CoinId}")]
//        public ActionResult GetCoin(Guid CoinId)
//        {
//            Coin CoinRec = _context.Coins.Where(c => c.Id == CoinId).First();
//            return Ok(CoinRec);
            
//        }
//        [HttpPost("PostCoin")]
//        public void PostCoin([FromBody] Coin CoinRec)
//        {
//            try
//            {
//                DynamicParameters parameters = newDynamicParameters();
//                parameters.Add("@CustomerName", entity.CustomerName);
//                parameters.Add("@CustomerEmail", entity.CustomerEmail);
//                parameters.Add("@CustomerMobile", entity.CustomerMobile);
//                SqlMapper.Execute(con, "AddCustomer", param parameters, commandTypeStoredProcedure);
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }

//        }
//        [HttpPost("PostCoins")]
//        public void PostCoins([FromBody] List<Coin> CoinList)
//        {
//            foreach (Coin CoinRec in CoinList)
//            {
//                _context.Coins.Add(CoinRec);

//            }
//            _context.SaveChanges();
//        }
//        [HttpPut("PutCoin/{CoinId}")]
//        public void PutCoin(Guid CoinId, [FromBody] Coin CoinRec)
//        {
//           _context.Coins.Update(CoinRec);
//           _context.SaveChanges();
//        }
//        [HttpDelete("DeleteCoin/{CoinId}")]
//        public void DeleteCoin(Guid CoinId)
//        {
//            //
//        }
 
//    }
//}
