using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models.DomainModels
{
    public class ContactFormViewModel
    {      
        [Required]
        [Display(Name = "Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Surname")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Enter e-mail in the correct format, e.g. login@provider")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Write your message. We'll contact you as fast as possible.")]
        public string Message { get; set; }

    }
}
