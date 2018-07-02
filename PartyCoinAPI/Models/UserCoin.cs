using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PartyCoinAPI.Models
{
    public class UserCoin
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public Guid Id { get; set; }

        //[ForeignKey("UserId")]
        [Required]
        public Guid UserId { get; set; }
        
        [Display(Name ="Quantity")]
        [Required]
        public string Qty { get; set; }

        [Required]
        [Display(Name = "Wallet")]
        public Guid WalletId { get; set; }

        [Required]
        [Display(Name ="Coin")]
        public Guid CoinId { get; set; }
    }
}
