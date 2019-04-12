using OnlineShop.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Helpers
{
    public static class ViewModelFactory
    {
        public static ProductViewModel MapProductToViewModel(ProductModel model)
        {
            ProductViewModel viewModel = new ProductViewModel()
            {
                Id = model.Id,
                Name = model.Name,
                Color = model.Color,
                Price = model.Price,
                Size = model.Size,
                Description = model.Description
            };
            return viewModel;
        }


        public static ProductViewModel MapProductsToViewModel(IEnumerable<ProductModel> models)
        {
            ProductViewModel viewModel = new ProductViewModel()
            {
                Id = models.First().Id,
                Name = models.First().Name,
                Price = models.First().Price,
                Description = models.First().Description,
                ColorSelectList = EnumHelpers.GetEnumSelectList(models.Select(x=>x.Color)),
                SizeSelectList = EnumHelpers.GetEnumSelectList(models.Select(x=>x.Size))
            };
            return viewModel;
        }

        public static ProductModel MapToModel(ProductViewModel viewModel)
        {
            ProductModel model = new ProductModel() {
                Color = viewModel.Color,
                Description = viewModel.Description,
                Id = viewModel.Id,
                Name = viewModel.Name,
                Price = viewModel.Price,
                Size = viewModel.Size
            };
            return model;
        }
    }
}
