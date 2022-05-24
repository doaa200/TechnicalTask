using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalTassk.DTO;
using TechnicalTassk.Models;

namespace TechnicalTassk.Services
{
    public class ProductService : IProductService
    {
        ApplicationDbContext context;
        public ProductService(ApplicationDbContext _context)
        {
            context = _context;
        }
        public List<Product> GetAll()
        {
            return context.products.ToList();
        }
        public Product GetById(int id)
        {
            return context.products.FirstOrDefault(p => p.ID == id);
        }
        public async Task<IEnumerable<Product>> Search(int id,string name, int price,int quantity)
        {
            IQueryable<Product> query = context.products;

            if (id != 0)
            {
                query = query.Where(e => e.ID == id);
            }
            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(e => e.Name.Contains(name));
            }

            if (price != 0)
            {
                query = query.Where(e => e.Price == price);
            }
            if (quantity != 0)
            {
                query = query.Where(e => e.Quantity == quantity);
            }

            return await query.ToListAsync();
        }
        public int Insert(ProductViewModel product)
        {
            context.products.Add(new Product
            {
                ID = product.ProductId,
                Name = product.ProductName,
                Price = product.ProductPrice,
                Quantity = product.ProductQuantity,
                Description = product.Description,
                Image = product.Photo
            });
            return context.SaveChanges();
        }

        public int Update(int id, ProductViewModel product)
        {
            Product oldproduct = GetById(id);
            if (oldproduct != null)
            {
                oldproduct.Name = product.ProductName;
                oldproduct.Price = product.ProductPrice;
                oldproduct.Quantity = product.ProductQuantity;
                oldproduct.Description = product.Description;
                oldproduct.Image = product.Photo;

                return context.SaveChanges();
            }
            return 0;
        }

        public int Delete(int id)
        {
            Product oldproduct = GetById(id);
            context.products.Remove(oldproduct);
            return context.SaveChanges();
        }


    }
}
