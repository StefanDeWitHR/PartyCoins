using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyCoinAPI.Models
{
    public class Menu
    {
        [Key]
        public string Id { get; set; }
        public string CmpId { get; set; }
        public string PartyId { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public float AlcholPerc { get; set; }
        public float Qty { get; set; }
        public int LActive { get; set; }
        public DateTime DtCreated { get; set; }
        public DateTime DtModified { get; set; }
    }
}
