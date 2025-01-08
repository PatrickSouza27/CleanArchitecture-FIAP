using CleanArch.Domain.Entities;
using CleanArch.Domain.Repositories;

namespace CleanArch.Infra.Data.Repositories;

public class ProductRepository : IProductRepository
{
    public IEnumerable<Product> GetProducts()
    {
        throw new NotImplementedException();
    }
}