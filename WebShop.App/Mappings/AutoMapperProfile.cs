using AutoMapper;
using WebShop.App.Models;
using WebShop.Core.Entities;

namespace WebShop.App.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, ProductModel>();
            CreateMap<ProductModel, Product>();
        }
    }
}
