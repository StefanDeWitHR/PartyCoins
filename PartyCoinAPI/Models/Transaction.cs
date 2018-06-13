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
        public string Id { get; set; }
        public string CmpId { get; set; }
        public string WalletId { get; set; }
        public string PartyId { get; set; }
        public string UserId { get; set; }
        public string PaymethodId { get; set; }
        public float Qty { get; set; }
        public int LActive { get; set; }
        public DateTime DtCreated { get; set; }
        public DateTime DtModified { get; set; }
    }
}
