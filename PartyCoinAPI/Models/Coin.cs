using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PartyCoinAPI.Models
{
    public class Coin
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public Guid PartyId { get; set; }

        [Required]
        public int AgeRequired { get; set; }

        public string Logo { get; set; }

        [Required]       
        public float Price { get; set; }

        [Required]
        public List<Currency> Currencys {get;set;}

        
        //Standard fields in model
        [Required]
        public int LActive { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DtCreated { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DtModified { get; set; }

    }
}
