using System.Collections.Generic;
using System.Linq;
using Andromeda.Data;
using Andromeda.Models;

namespace Andromeda.Services
{
    public class LikeService : ILikeService
    {
        private readonly AndromedaContext _context;

        public LikeService(AndromedaContext context)
        {
            _context = context;
        }

        public IEnumerable<Like> GetAll()
        {
            return _context.Likes.ToList();
        }

        public Like GetById(int id)
        {
            return _context.Likes.Find(id);
        }

        public Like Create(Like like)
        {
            _context.Likes.Add(like);
            _context.SaveChanges();
            return like;
        }

        public void Update(Like like)
        {
            _context.Likes.Update(like);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var like = _context.Likes.Find(id);
            if (like != null)
            {
                _context.Likes.Remove(like);
                _context.SaveChanges();
            }
        }
    }
}
