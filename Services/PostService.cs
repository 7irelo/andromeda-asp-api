using System.Collections.Generic;
using System.Linq;
using Andromeda.Data;
using Andromeda.Models;

namespace Andromeda.Services
{
    public class PostService : IPostService
    {
        private readonly AndromedaContext _context;

        public PostService(AndromedaContext context)
        {
            _context = context;
        }

        public IEnumerable<Post> GetAll()
        {
            return _context.Posts.ToList();
        }

        public Post GetById(int id)
        {
            return _context.Posts.Find(id);
        }

        public Post Create(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
            return post;
        }

        public void Update(Post post)
        {
            _context.Posts.Update(post);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var post = _context.Posts.Find(id);
            if (post != null)
            {
                _context.Posts.Remove(post);
                _context.SaveChanges();
            }
        }
    }
}
