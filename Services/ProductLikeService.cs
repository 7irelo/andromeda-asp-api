using System.Collections.Generic;
using System.Linq;
using Andromeda.Data;
using Andromeda.Models;

namespace Andromeda.Services
{
    public class ProductLikeService : IProductLikeService
    {
        private readonly AndromedaContext _context;

        public ProductLikeService(AndromedaContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductLike> GetAll()
        {
            return _context.ProductLikes.ToList();
        }

        public ProductLike GetById(int id)
        {
            return _context.ProductLikes.Find(id);
        }

        public ProductLike Create(ProductLike productLike)
        {
            _context.ProductLikes.Add(productLike);
            _context.SaveChanges();
            return productLike;
        }

        public void Update(ProductLike productLike)
        {
            _context.ProductLikes.Update(productLike);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var productLike = _context.ProductLikes.Find(id);
            if (productLike != null)
            {
                _context.ProductLikes.Remove(productLike);
                _context.SaveChanges();
            }
        }
    }
}
