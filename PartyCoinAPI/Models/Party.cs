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
        public string Id { get; set; }
        public string CmpId { get; set; }
        public string StatusId { get; set; }
        public DateTime DtParty { get; set; }
        public string Name { get; set; }
        public string Adres { get; set; }
        public string ZipCode { get; set; }
        public string Website { get; set; }
        public string CoordX { get; set; }
        public string CoordY { get; set; }
        public string Logo { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string LongDescription { get; set; }
        public string LineUp { get; set; }        
        public int AgeRequired { get; set; }       
        public int LActive { get; set; }
        public DateTime DtCreated { get; set; }
        public DateTime DtModified { get; set; }
    }
}
