using MyProject.Application.Interfaces;
using MyProject.Domain.Entities;
using MyProject.Domain.Interfaces;

namespace MyProject.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        public ProductService(IProductRepository repository) => _repository = repository;

        public Task<IEnumerable<Product>> GetAllAsync() => _repository.GetAllAsync();
        public Task<Product?> GetByIdAsync(Guid id) => _repository.GetByIdAsync(id);
        public Task AddAsync(Product product) => _repository.AddAsync(product);
        public Task UpdateAsync(Product product) => _repository.UpdateAsync(product);
        public Task DeleteAsync(Guid id) => _repository.DeleteAsync(id);
    }
}