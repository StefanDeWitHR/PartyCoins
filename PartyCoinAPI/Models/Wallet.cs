using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PartyCoinAPI.Models
{
    public class Wallet
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public string Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public string PartyId { get; set; } // One wallet for each party

        [Display(Name = "Amount of coins")]
        [Required]
        public float Qty {get;set;}

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
