using System.Collections.Generic;
using System.Linq;
using Andromeda.Data;
using Andromeda.Models;

namespace Andromeda.Services
{
    public class ProductService : IProductService
    {
        private readonly AndromedaContext _context;

        public ProductService(AndromedaContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product GetById(int id)
        {
            return _context.Products.Find(id);
        }

        public Product Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public void Update(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }
    }
}
