using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class SignUp
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Email cant be empty")]
        [EmailAddress]
        [DataType(DataType.EmailAddress,ErrorMessage ="your email isn't valid")]
        public string EmailAddress { get; set; }


        [Required(ErrorMessage = "User name can't be empty")]
        [Display(Name="User name")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Password can't be empty")]
        [Display(Name ="Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
