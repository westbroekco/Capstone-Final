using CKK.Logic.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CKK.DB.Interfaces
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public Task<IReadOnlyList<Product>> GetByNameAsync(string name);
        public List<Product> GetAll();
        public int Update(Product entity);
    }
}