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
    [Authorize(Roles = "Admin")]
    [Route("[controller]")]
    public class PartyController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PartyController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetPartys")]
        public ActionResult GetPartys()
        {
            List<Party> PartyList = _context.Partys.ToList();
            return Ok(PartyList);
        }
        [HttpGet("GetParty/{PartyId}")]
        public ActionResult GetParty(Guid PartyId)
        {
            Party PartyRec = _context.Partys.Where(g => g.Id == PartyId).First();
            return Ok(PartyRec);        
        }
        [HttpPost("PostParty")]
        public void PostParty([FromBody] Party PartyRec)
        {
            _context.Partys.Add(PartyRec);
            _context.SaveChanges();
        }
        [HttpPost("PostPartys")]
        public void PostPartys([FromBody] List<Party> PartyList)
        {
            foreach (Party PartyRec in PartyList)
            {
                _context.Partys.Add(PartyRec);
            }
            _context.SaveChanges();
        }
        [HttpPut("PutParty/{PartyId}")]
        public void PutParty(Guid PartyId, [FromBody] Party PartyRec)
        {
            _context.Partys.Update(PartyRec);
            _context.SaveChanges();
        }

        [HttpDelete("DeleteParty/{PartyId}")]
        public void DeleteParty(Guid PartyId)
        {
           //
        }
    }
}
