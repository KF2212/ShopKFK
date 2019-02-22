using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Validators
{
    public class PasswordValidator
    {

        public static bool IsPasswordCorracet(UserViewModel user)
        {
            return user.Password.Length < 3;
        }
    }
}
