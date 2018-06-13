using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyCoinAPI.Models
{
    public class Coin
    {
        [Key]
        public string Id { get; set; }
        public string CmpId { get; set; }
        public string PartyId { get; set; }
        public int AgeRequired { get; set; }
        public string Logo { get; set; }
        public float Price { get; set; }
        public int LActive { get; set; }
        public DateTime DtCreated { get; set; }
        public DateTime DtModified { get; set; }

    }
}
