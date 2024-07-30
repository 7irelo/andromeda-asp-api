using System.Collections.Generic;
using System.Linq;
using Andromeda.Data;
using Andromeda.Models;

namespace Andromeda.Services
{
    public class ChatService : IChatService
    {
        private readonly AndromedaContext _context;

        public ChatService(AndromedaContext context)
        {
            _context = context;
        }

        public IEnumerable<Chat> GetAll()
        {
            return _context.Chats.ToList();
        }

        public Chat GetById(int id)
        {
            return _context.Chats.Find(id);
        }

        public Chat Create(Chat chat)
        {
            _context.Chats.Add(chat);
            _context.SaveChanges();
            return chat;
        }

        public void Update(Chat chat)
        {
            _context.Chats.Update(chat);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var chat = _context.Chats.Find(id);
            if (chat != null)
            {
                _context.Chats.Remove(chat);
                _context.SaveChanges();
            }
        }
    }
}
