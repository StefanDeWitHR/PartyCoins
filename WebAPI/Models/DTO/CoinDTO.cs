using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models.DTO
{
    public class CoinDTO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public Guid PartyId { get; set; }

        [Required]
        [Display(Name = "Age required")]
        public int AgeRequired { get; set; }

        [Display(Name = "Logo coin")]
        public string Logo { get; set; }

        [Required]
        [Display(Name = "Price")]
        public float Price { get; set; }


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
