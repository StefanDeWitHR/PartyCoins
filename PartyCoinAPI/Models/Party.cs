using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyCoinAPI.Models
{
    public class Party
    {
        [Key]
        public Guid guid { get; set; }
        public Guid guid_company { get; set; }
        public DateTime dt_party { get; set; }
        public string name { get; set; }
        public string adres { get; set; }
        public string zip_code { get; set; }
        public string website { get; set; }
        public string coord_x { get; set; }
        public string coord_y { get; set; }
        public string logo { get; set; }
        public float price { get; set; }
        public string desc { get; set; }
        public string long_desc { get; set; }
        public string line_up { get; set; }        
        public int age_required { get; set; }
        public int status { get; set; }
        public int l_active { get; set; }
        public DateTime dt_created { get; set; }
        public DateTime dt_modified { get; set; }
    }
}
