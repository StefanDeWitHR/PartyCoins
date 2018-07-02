using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace PartyCoinAPI.Models
{
    public class UserRole : IdentityRole
    {
        
        [Required]
       // [ForeignKey("CmpId")]
        public Guid CmpId { get; set; } // Empty guid is a role for everyone

        //public string UserId { get; set; } // Empty guid is a role for everyone

        //public ApplicationUser User { get; set; }

        [Required]
       // [ForeignKey("PartyId")]
        public Guid PartyId { get; set; }

    }
}
