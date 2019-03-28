using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineShop.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class ProductViewModel
    {
        public Sizes Size { get; set; }
        public IEnumerable<SelectListItem> SizeSelectList
        {
            get
            {
                return EnumHelpers.GetEnumSelectList<Sizes>();
            }
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Colors Color { get; set; }
        public IEnumerable<SelectListItem> ColorSelectList
        {
            get
            {
                return EnumHelpers.GetEnumSelectList<Colors>();
            }
        }
    }
}
