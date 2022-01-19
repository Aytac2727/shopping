using DataAccess;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class ProductManager
    {
        private readonly ApplicationDbContext _context;

        public ProductManager(ApplicationDbContext context)
        {
            _context = context;

        }

        public List<Product> GetProducts()
        {
            

            return _context.Products.ToList();
        }

        public Product GetProduct(int? id)
        {
            return _context.Products.Find(id);
        }

        public List<Product> GetSameProducts(int? id,int? categoryId)
        {
            return _context.Products.Where(x=>x.ID!=id && x.CategoryId==categoryId).ToList();
        }
        public void Add(Product product)
        {
             _context.Products.Add(product);
            _context.SaveChanges(); 
        }

    }
}
