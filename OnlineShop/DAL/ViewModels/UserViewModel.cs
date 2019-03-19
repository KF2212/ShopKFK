using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.ViewModels
{
    public class UserViewModel
    {
        [Display(Name = "Twoje ID")]
        [Range(100000, 9999999, ErrorMessage = "musisz wprowadzic prawidłowy numer")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Musisz podać login!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Musisz podać hasło!")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 5, ErrorMessage ="Musisz podać hasło któe bedzie miało powyzej 5 znaków!")]
        public string Password { get; set; }
    }
}
