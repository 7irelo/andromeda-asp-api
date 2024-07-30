using System.Collections.Generic;
using System.Linq;
using Andromeda.Data;
using Andromeda.Models;

namespace Andromeda.Services
{
    public class CommentService : ICommentService
    {
        private readonly AndromedaContext _context;

        public CommentService(AndromedaContext context)
        {
            _context = context;
        }

        public IEnumerable<Comment> GetAll()
        {
            return _context.Comments.ToList();
        }

        public Comment GetById(int id)
        {
            return _context.Comments.Find(id);
        }

        public Comment Create(Comment comment)
        {
            _context.Comments.Add(comment);
            _context.SaveChanges();
            return comment;
        }

        public void Update(Comment comment)
        {
            _context.Comments.Update(comment);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var comment = _context.Comments.Find(id);
            if (comment != null)
            {
                _context.Comments.Remove(comment);
                _context.SaveChanges();
            }
        }
    }
}
