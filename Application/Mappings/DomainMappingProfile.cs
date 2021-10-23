using Application.DTOs.Product;
using Application.DTOs.ProductCategory;
using Application.DTOs.ProductModel;
using Application.DTOs.ProductSubCategory;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
{
    public class DomainMappingProfile : Profile
    {
        public DomainMappingProfile()
        {
            ProductDTOProfile();
            ProductModelProfile();
            ProductCategoryProfile();
            ProductSubCategoryProfile();
        }

        private void ProductDTOProfile()
        {
            CreateMap<Product, ProductGetDTO>().ReverseMap();
            CreateMap<Product, ProductPostDTO>().ReverseMap();
            CreateMap<Product, ProductPutDTO>().ReverseMap();
        }

        private void ProductModelProfile()
        {
            CreateMap<ProductModel, ProductModelGetDTO>().ReverseMap();
            CreateMap<Product, ProductModelPostDTO>().ReverseMap();
            CreateMap<Product, ProductModelPutDTO>().ReverseMap();
        }

        private void ProductCategoryProfile()
        {
            CreateMap<Product, ProductCategoryGetDTO>().ReverseMap();
            CreateMap<Product, ProductCategoryPostDTO>().ReverseMap();
            CreateMap<Product, ProductCategoryPutDTO>().ReverseMap();
        }

        private void ProductSubCategoryProfile()
        {
            CreateMap<Product, ProductSubCategoryGetDTO>().ReverseMap();
            CreateMap<Product, ProductSubCategoryPostDTO>().ReverseMap();
            CreateMap<Product, ProductSubCategoryPutDTO>().ReverseMap();
        }
    }
}