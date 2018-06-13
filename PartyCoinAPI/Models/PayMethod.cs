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
        public string Id { get; set; }
        public string CmpId { get; set;} // in case of special paymethod methods(Empty guid = valid for all companys)
        public string Provider { get; set; }
        public int LActive { get; set; }
        public DateTime DtCreated { get; set; }
        public DateTime DtModified { get; set; }

    }
}
