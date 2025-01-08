using CleanArch.Application.DTOs;
using CleanArch.Domain.Repositories;

namespace CleanArch.Application.UseCases;

public class ProductUseCases
{
    private readonly IProductRepository _productRepository;
    
    public ProductUseCases(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    
    public IEnumerable<ProductDto> GetProducts()
    {
        var products = _productRepository.GetProducts();
        return products.Select(p => new ProductDto
        {
            Name = p.Name,
            Price = p.Price
        });
    }
}