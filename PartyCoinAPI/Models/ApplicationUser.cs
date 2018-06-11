using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PartyCoinAPI.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        
        [Key]
        [Required]
        public Guid guid { get; set; }
        [Required]
        public Guid guid_company { get; set; }
        [Required]
        public DateTime dt_birth { get; set; }
        [Required]
        public int user_level { get; set; }
        public int l_active { get; set; }
        public DateTime dt_lastlogin { get; set; }
        [Required]
        public DateTime dt_created { get; set; }
        public DateTime dt_modified { get; set; }
    }
}
