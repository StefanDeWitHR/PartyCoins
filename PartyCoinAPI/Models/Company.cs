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
        public Guid Id { get; set; }
       
        public List<Party> Partys { get; set; }

        public List<ApplicationUser> Users { get; set; }

        public List<PayMethod> PayMethods { get; set; }

        [Display(Name = "Name")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Email")]
        [Required]
        public string Email { get; set; }

        [Display(Name = "Phone")]
        [Required]
        public string Phone { get; set; }

        [Display(Name = "Zip code")]
        [Required]
        public string ZipCode { get; set; }

        [Display(Name = "Website")]
        public string Website { get; set; }

        [Display(Name = "Address")]
        [Required]
        public string Addresss { get; set; }

        [Display(Name= "City")]
        [Required]
        public string City { get; set; }

        [Display(Name = "Country")]
        [Required]
        public string Country { get; set; }
        
        [Display(Name = "KVK number")]
        [Required]
        public string KvkNum { get; set; }

        [Display(Name ="VAT number")]
        [Required]
        public string VatNum { get; set; }

        [Display(Name = "Bank")]
        public string Bank { get; set; }

        [Display(Name = "Currency")]
        [Required]
        public List<Currency> Currenys { get; set; }      

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
