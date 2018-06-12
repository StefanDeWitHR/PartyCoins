using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyCoinAPI.Models
{
    public class Menu
    {
        public Guid guid { get; set; }
        public Guid guid_cmp { get; set; }
        public Guid guid_party { get; set; }
        public string description { get; set; }
        public string ingredients { get; set; }
        public float alchol_perc { get; set; }
        public float amount_coins { get; set; }
        public int l_active { get; set; }
        public DateTime dt_created { get; set; }
        public DateTime dt_modified { get; set; }
    }
}
