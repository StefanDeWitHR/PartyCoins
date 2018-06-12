using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyCoinAPI.Models
{
    public class PayMethod
    {
        [Key]
        public Guid guid { get; set; }
        public Guid guid_cmp { get; set;} // in case of special paymethod methods(Empty guid = valid for all companys)
        public string provider { get; set; }
        public DateTime dt_created { get; set; }
        public DateTime dt_modified { get; set; }
        public int l_active { get; set; }

    }
}
