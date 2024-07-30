using System.Collections.Generic;
using System.Linq;
using Andromeda.Data;
using Andromeda.Models;

namespace Andromeda.Services
{
    public class MessageService : IMessageService
    {
        private readonly AndromedaContext _context;

        public MessageService(AndromedaContext context)
        {
            _context = context;
        }

        public IEnumerable<Message> GetAll()
        {
            return _context.Messages.ToList();
        }

        public Message GetById(int id)
        {
            return _context.Messages.Find(id);
        }

        public Message Create(Message message)
        {
            _context.Messages.Add(message);
            _context.SaveChanges();
            return message;
        }

        public void Update(Message message)
        {
            _context.Messages.Update(message);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var message = _context.Messages.Find(id);
            if (message != null)
            {
                _context.Messages.Remove(message);
                _context.SaveChanges();
            }
        }
    }
}
