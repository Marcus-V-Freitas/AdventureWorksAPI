using Data.Context;
using Domain.Entities;
using Domain.Interfaces;

namespace Data.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(AdventureWorksContext context) : base(context)
        {
        }
    }
}