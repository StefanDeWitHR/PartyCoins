using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyCoinAPI.Models
{
 
    public class UserLogin
    {
        public string email { get; set; }
        public string password { get; set; }
    }
}
