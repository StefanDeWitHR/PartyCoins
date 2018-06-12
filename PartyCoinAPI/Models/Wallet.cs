using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyCoinAPI.Models
{
    public class Wallet
    {
        public Guid guid { get; set; }
        public Guid guid_user { get; set; }
        public Guid guid_party { get; set; } // One wallet for each party
        public float qty_coins {get;set;}
        public int l_active { get; set; }
        public DateTime dt_created { get; set; }
        public DateTime dt_modified { get; set; }

    }
}
