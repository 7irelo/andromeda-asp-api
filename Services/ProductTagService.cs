using System.Collections.Generic;
using System.Linq;
using Andromeda.Data;
using Andromeda.Models;

namespace Andromeda.Services
{
    public class ProductTagService : IProductTagService
    {
        private readonly AndromedaContext _context;

        public ProductTagService(AndromedaContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductTag> GetAll()
        {
            return _context.ProductTags.ToList();
        }

        public ProductTag GetById(int id)
        {
            return _context.ProductTags.Find(id);
        }

        public ProductTag Create(ProductTag productTag)
        {
            _context.ProductTags.Add(productTag);
            _context.SaveChanges();
            return productTag;
        }

        public void Update(ProductTag productTag)
        {
            _context.ProductTags.Update(productTag);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var productTag = _context.ProductTags.Find(id);
            if (productTag != null)
            {
                _context.ProductTags.Remove(productTag);
                _context.SaveChanges();
            }
        }
    }
}
