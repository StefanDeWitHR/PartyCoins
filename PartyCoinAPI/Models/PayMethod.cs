using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PartyCoinAPI.Models
{
    public class PayMethod
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public string Id { get; set; }

        [Required]
        public string CmpId { get; set;} // in case of special paymethod methods(Empty guid = valid for all companys)

        [Display(Name = "Provider")]
        [Required]
        public string Provider { get; set; }

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
