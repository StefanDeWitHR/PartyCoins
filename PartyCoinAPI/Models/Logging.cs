using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PartyCoinAPI.Models
{
    public class Logging
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public string Guid { get; set; }

        [Display(Name = "Type logging")]
        public string Type { get; set; }

        [Display(Name= "Error message")]
        public string Message { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Date created")]
        public DateTime DtCreated { get; set; }
        [DataType(DataType.DateTime)]
        [Display(Name = "Date modified")]
        public DateTime DtModified { get; set; }

        
        public void GenerateLoggingFileIfNotExist()
        {

        }
        public void AddLoggingToFile(Logging LoggingRec)
        {

        }
    }
}
