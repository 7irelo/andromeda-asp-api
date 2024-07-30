using System.Collections.Generic;
using System.Linq;
using Andromeda.Data;
using Andromeda.Models;

namespace Andromeda.Services
{
    public class TagService : ITagService
    {
        private readonly AndromedaContext _context;

        public TagService(AndromedaContext context)
        {
            _context = context;
        }

        public IEnumerable<Tag> GetAll()
        {
            return _context.Tags.ToList();
        }

        public Tag GetByName(string name)
        {
            return _context.Tags.Find(name);
        }

        public Tag Create(Tag tag)
        {
            _context.Tags.Add(tag);
            _context.SaveChanges();
            return tag;
        }

        public void Update(Tag tag)
        {
            _context.Tags.Update(tag);
            _context.SaveChanges();
        }

        public void Delete(string name)
        {
            var tag = _context.Tags.Find(name);
            if (tag != null)
            {
                _context.Tags.Remove(tag);
                _context.SaveChanges();
            }
        }
    }
}
