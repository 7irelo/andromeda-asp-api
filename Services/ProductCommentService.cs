using System.Collections.Generic;
using System.Linq;
using Andromeda.Data;
using Andromeda.Models;

namespace Andromeda.Services
{
    public class ProductCommentService : IProductCommentService
    {
        private readonly AndromedaContext _context;

        public ProductCommentService(AndromedaContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductComment> GetAll()
        {
            return _context.ProductComments.ToList();
        }

        public ProductComment GetById(int id)
        {
            return _context.ProductComments.Find(id);
        }

        public ProductComment Create(ProductComment productComment)
        {
            _context.ProductComments.Add(productComment);
            _context.SaveChanges();
            return productComment;
        }

        public void Update(ProductComment productComment)
        {
            _context.ProductComments.Update(productComment);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var productComment = _context.ProductComments.Find(id);
            if (productComment != null)
            {
                _context.ProductComments.Remove(productComment);
                _context.SaveChanges();
            }
        }
    }
}
