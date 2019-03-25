using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Helpers
{
    public enum Sizes
    {
        Unknown = 0,
        XS = 1,
        S = 2,
        M = 3,
        L = 4,
        XL = 5,
        XXL = 6,
        XXXL = 7
    }

    public enum Colors
    {
        Unknown = 0,
        Black = 1,
        White = 2,
        Red = 3
    }

    public static class EnumHelpers
    {
        public static IEnumerable<SelectListItem> GetEnumSelectList<T>()
        {
            return (Enum.GetValues(typeof(T)).Cast<int>().Select(e => new SelectListItem() { Text = Enum.GetName(typeof(T), e), Value = e.ToString() })).ToList();
        }
    }

}
