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
        [Required]
        public Guid CmpId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of birth")]
        public DateTime DtBirth { get; set; }

        [Required]
        public string UserRoleId { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Date last login")]
        public DateTime DtLastLogin { get; set; }

        //Standard fields in model
        [Required]
        [Display(Name = "Active")]
        public int LActive { get; set; }       
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Date created")]
        public DateTime DtCreated { get; set; }
        [DataType(DataType.DateTime)]
        [Display(Name = "Date modified")]
        public DateTime DtModified { get; set; }
    }
}
