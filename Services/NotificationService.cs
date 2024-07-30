using System.Collections.Generic;
using System.Linq;
using Andromeda.Data;
using Andromeda.Models;

namespace Andromeda.Services
{
    public class NotificationService : INotificationService
    {
        private readonly AndromedaContext _context;

        public NotificationService(AndromedaContext context)
        {
            _context = context;
        }

        public IEnumerable<Notification> GetAll()
        {
            return _context.Notifications.ToList();
        }

        public Notification GetById(int id)
        {
            return _context.Notifications.Find(id);
        }

        public Notification Create(Notification notification)
        {
            _context.Notifications.Add(notification);
            _context.SaveChanges();
            return notification;
        }

        public void Update(Notification notification)
        {
            _context.Notifications.Update(notification);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var notification = _context.Notifications.Find(id);
            if (notification != null)
            {
                _context.Notifications.Remove(notification);
                _context.SaveChanges();
            }
        }
    }
}
