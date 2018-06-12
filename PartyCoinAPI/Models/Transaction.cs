using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyCoinAPI.Models
{
    public class Transaction
    {
        [Key]
        public Guid guid { get; set; }
        public Guid guid_company { get; set; }
        public Guid guid_wallet { get; set; }
        public Guid guid_party { get; set; }
        public Guid guid_user { get; set; }
        public Guid guid_paymethod { get; set; }
        public float qty_coins { get; set; }      
        public int status { get; set; }
        public DateTime dt_created { get; set; }
        public DateTime dt_modified { get; set; }
    }
}
