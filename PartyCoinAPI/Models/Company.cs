using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartyCoinAPI.Models
{
    public class Company
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public string Id { get; set; }

        [Display(Name = "Name")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Phone")]
        [Required]
        public string Phone { get; set; }

        [Display(Name = "Zip code")]
        [Required]
        public string Zipcode { get; set; }

        [Display(Name = "Website")]
        public string Website { get; set; }

        [Display(Name = "Adres")]
        [Required]
        public string Adres { get; set; }

        [Display(Name = "KVK number")]
        [Required]
        public string KvkNum { get; set; }

        [Display(Name = "Bank")]
        [Required]
        public string Bank { get; set; }

        [Display(Name = "Currency")]
        [Required]
        public string Curreny { get; set; }

        [Display(Name = "Country")]
        [Required]
        public string Country { get; set; }

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
