using Application.DTOs.Product;
using Application.Services.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services.Repository
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _productRepository.DeleteAsync(x => x.ProductID == id);
        }

        public async Task<bool> EditAsync(ProductPutDTO model)
        {
            var product = _mapper.Map<Product>(model);
            return await _productRepository.EditAsync(product, product.ProductID);
        }

        public async Task<List<ProductGetDTO>> FindAllAsync(string search)
        {
            var products = await _productRepository.FindAllAsync(x => x.Name.ToUpper().Contains(search.ToUpper()));
            return _mapper.Map<List<ProductGetDTO>>(products);
        }

        public async Task<List<ProductGetDTO>> FindAllAsync()
        {
            var products = await _productRepository.FindAllAsync();
            return _mapper.Map<List<ProductGetDTO>>(products);
        }

        public async Task<ProductGetDTO> FindAsync(int id)
        {
            var product = await _productRepository.FindAsync(x => x.ProductID == id);
            return _mapper.Map<ProductGetDTO>(product);
        }

        public async Task<ProductGetDTO> InsertAsync(ProductPostDTO model)
        {
            var product = _mapper.Map<Product>(model);
            var productInserted = await _productRepository.InsertAsync(product);
            return _mapper.Map<ProductGetDTO>(productInserted);
        }
    }
}