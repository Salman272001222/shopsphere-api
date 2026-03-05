using ShopSphere.API.Models;

namespace ShopSphere.API.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAll();

        Task<Product> GetById(int id);

        Task<Product> Add(Product product);

        Task Update(Product product);

        Task Delete(int id);
    }
}