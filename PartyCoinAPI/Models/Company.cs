using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyCoinAPI.Models
{
    public class Company
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Zipcode { get; set; }
        public string Website { get; set; }
        public string Adres { get; set; }
        public string KvkNum { get; set; }
        public string Bank { get; set; }
        public string Curreny { get; set; }
        public string Country { get; set; }
        public int LActive { get; set; }
        public DateTime DtCreated { get; set; }
        public DateTime DtModified { get; set; }
    }
}
