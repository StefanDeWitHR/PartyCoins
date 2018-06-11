using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyCoinAPI.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        //[DataType(DataType.DateTime)]
        //[Display(Name = "Date of birth")]
        //[Compare("Date of Birth", ErrorMessage = "The date of birth is not valid!")]
        public DateTime dt_birth { get; set; }


        //[DataType(DataType.Text)]
        //[Display(Name = "Company")]
        //[Compare("Company", ErrorMessage = "Company not set")]
        public string guid_company { get; set; }
        public int user_level { get; set; }
        public int l_active { get; set; }
        public DateTime dt_created { get; set; }

    }




}
