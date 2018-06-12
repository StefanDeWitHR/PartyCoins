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
            List<Party> party_list = _context.Partys.ToList();
            if (party_list.Count > 0)
            {
                throw new Exception("List contains 0 elements");

            }
            return Ok(party_list);
        }
        [HttpGet("GetParty/{guid_party}")]
        public ActionResult GetParty(Guid guid_party)
        {
            Party party = _context.Partys.Where(g => g.guid == guid_party).First();
            if (party == null)
            {
                throw new System.ArgumentException("Company not found ");
            }
            else
            {
                return Ok(party);
            }
        }
        [HttpPost("PostParty")]
        public void PostParty([FromBody] Party party)
        {
            if (party == null)
            {
                throw new Exception("Party is empty or null try again");
            }
            else
            {

                _context.Partys.Add(party);
                _context.SaveChanges();
            }
        }
        [HttpPost("PostPartys")]
        public void PostPartys([FromBody] List<Party> party)
        {
            if (party == null)
            {
                throw new Exception("Party is empty or null try again");
            }
            else
            {
                foreach (Party p in party)
                {
                    _context.Partys.Add(p);
                }

                _context.SaveChanges();
            }
        }
        [HttpPut("PutParty/{guid_party}")]
        public void PutParty(Guid guid_party, [FromBody] Party party)
        {
            if (guid_party == null || party == null)
            {
                throw new Exception("Wrong guid or party record");
            }
            else
            {
                _context.Partys.Update(party);
                _context.SaveChanges();
            }
        }

        [HttpDelete("DeleteParty/{guid_party}")]
        public void DeleteParty(Guid guid_party)
        {
           //
        }
    }
}
