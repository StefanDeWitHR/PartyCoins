using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PartyCoinAPI.Models
{
    public class Transaction
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public string Id { get; set; }

        [Required]
        public string CmpId { get; set; }

        [Required]
        public string WalletId { get; set; }

        [Required]
        public string PartyId { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public string PaymethodId { get; set; }

        [Display(Name = "Amount")]
        [Required]
        public float Qty { get; set; }

        //Standard fields in model
        [Required]
        [Display(Name = "Active")]
        public int LActive { get; set; }
        [DataType(DataType.DateTime)]
        [Display(Name = "Date created")]
        public DateTime DtCreated { get; set; }
        [DataType(DataType.DateTime)]
        [Display(Name = "Date modified")]
        public DateTime DtModified { get; set; }
    }
}
