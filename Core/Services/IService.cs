using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IService<T>
    {
        Task<T> InsertAsync(T model);

        Task<bool> EditAsync(T model);

        Task<bool> DeleteAsync(int id);

        Task<List<T>> FindAllAsync(string search);

        Task<List<T>> FindAllAsync();

        Task<T> FindAsync(int id);
    }
}