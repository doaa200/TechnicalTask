using System.Collections.Generic;
using System.Threading.Tasks;
using TechnicalTassk.DTO;
using TechnicalTassk.Models;

namespace TechnicalTassk.Services
{
    public interface IProductService
    {
        int Delete(int id);
        List<Product> GetAll();
        Task<IEnumerable<Product>> Search(int id, string name, int price, int quantity);
        Product GetById(int id);
        int Insert(ProductViewModel product);
        int Update(int id, ProductViewModel product);
    }
}