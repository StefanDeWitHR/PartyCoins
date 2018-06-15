using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PartyCoinAPI.Models
{
    public class Party
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public string Id { get; set; }

        [Required]
        public string CmpId { get; set; }

        [Required]
        public string StatusId { get; set; }

        [Display(Name = "Date of party")]
        [Required]
        public DateTime DtParty { get; set; }

        [Display(Name = "Name")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Adres")]
        [Required]
        public string Adres { get; set; }

        [Display(Name = "Zip code")]
        [Required]
        public string ZipCode { get; set; }

        [Display(Name = "Website")]
        public string Website { get; set; }

       
        [Required]
        public string CoordX { get; set; }

        [Required]
        public string CoordY { get; set; }

        [Display(Name = "Logo")]
        [Required]
        public string Logo { get; set; }

        [Display(Name = "Price")]
        [Required]
        public float Price { get; set; }

        [Display(Name = "Description")]
        [Required]
        public string Description { get; set; }

        [Display(Name = "Long description")]
        public string LongDescription { get; set; }

        [Display(Name = "Line up")]
        [Required]
        public string LineUp { get; set; }

        [Display(Name = "Age required")]
        [Required]
        public int AgeRequired { get; set; }

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
