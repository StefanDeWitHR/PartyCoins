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
        public Guid guid { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string zipcode { get; set; }
        public string website { get; set; }
        public string adres { get; set; }
        public string kvk_num { get; set; }
        public string bank { get; set; }
        public string curreny { get; set; }
        public string country { get; set; }
        public int l_active { get; set; }
        public DateTime dt_created { get; set; }
        public DateTime dt_modified { get; set; }
    }
}
