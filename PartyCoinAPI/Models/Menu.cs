using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PartyCoinAPI.Models
{
    public class Menu
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public string Id { get; set; }

        [Required]
        public string CmpId { get; set; }

        [Required]
        public string PartyId { get; set; }

        [Display(Name = "Description")]
        [Required]
        public string Description { get; set; }

        [Display(Name = "Ingredients")]
        [Required]
        public string Ingredients { get; set; }

        [Display(Name = "Alcohol percentage")]
        [Required]
        public float AlcholPerc { get; set; }

        [Display(Name = "Amount of coins")]
        [Required]
        public float Qty { get; set; } // amount of coins

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
