using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Repositories;

public interface IProductRepository
{
    IEnumerable<Product> GetProducts();
}