using ShopSphere.API.Models;
using ShopSphere.API.Repositories;

namespace ShopSphere.API.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _repository.GetAll();
        }

        public async Task<Product> GetProduct(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task<Product> CreateProduct(Product product)
        {
            return await _repository.Add(product);
        }

        public async Task UpdateProduct(Product product)
        {
            await _repository.Update(product);
        }

        public async Task DeleteProduct(int id)
        {
            await _repository.Delete(id);
        }
    }
}