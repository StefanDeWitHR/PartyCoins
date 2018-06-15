using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace PartyCoinAPI.Models
{
    public class UserRoles : IdentityRole
    {
        
        [Required]
        public string CmpId { get; set; } // Empty guid is a role for everyone

    }
}
