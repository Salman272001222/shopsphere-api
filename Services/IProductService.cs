using ShopSphere.API.Models;

namespace ShopSphere.API.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProducts();

        Task<Product> GetProduct(int id);

        Task<Product> CreateProduct(Product product);

        Task UpdateProduct(Product product);

        Task DeleteProduct(int id);
    }
}