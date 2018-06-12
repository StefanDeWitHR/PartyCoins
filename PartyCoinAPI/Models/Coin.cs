using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyCoinAPI.Models
{
    public class Coin
    {
        public Guid guid { get; set; }
        public Guid guid_cmp { get; set; }
        public Guid guid_party { get; set; }
        public int age_required { get; set; }
        public string logo { get; set; }
        public float price { get; set; }
        public int l_show { get; set; }
        public DateTime dt_created { get; set; }
        public DateTime dt_modified { get; set; }

    }
}
