using System.Collections.Generic;
using System.Linq;
using Andromeda.Data;
using Andromeda.Models;

namespace Andromeda.Services
{
    public class FriendshipService : IFriendshipService
    {
        private readonly AndromedaContext _context;

        public FriendshipService(AndromedaContext context)
        {
            _context = context;
        }

        public IEnumerable<Friendship> GetAll()
        {
            return _context.Friendships.ToList();
        }

        public Friendship GetById(int id)
        {
            return _context.Friendships.Find(id);
        }

        public Friendship Create(Friendship friendship)
        {
            _context.Friendships.Add(friendship);
            _context.SaveChanges();
            return friendship;
        }

        public void Update(Friendship friendship)
        {
            _context.Friendships.Update(friendship);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var friendship = _context.Friendships.Find(id);
            if (friendship != null)
            {
                _context.Friendships.Remove(friendship);
                _context.SaveChanges();
            }
        }
    }
}
