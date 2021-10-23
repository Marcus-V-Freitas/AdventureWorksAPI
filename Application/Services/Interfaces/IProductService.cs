using Application.DTOs.Product;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IProductService
    {
        Task<ProductGetDTO> InsertAsync(ProductPostDTO model);

        Task<bool> EditAsync(ProductPutDTO model);

        Task<bool> DeleteAsync(int id);

        Task<List<ProductGetDTO>> FindAllAsync(string search);

        Task<List<ProductGetDTO>> FindAllAsync();

        Task<ProductGetDTO> FindAsync(int id);
    }
}