using System.Linq;
using Andromeda.Data;
using Andromeda.Models;

namespace Andromeda.Services
{
    public class AuthService : IAuthService
    {
        private readonly AndromedaContext _context;
        private readonly JwtHelper _jwtHelper;

        public AuthService(AndromedaContext context, JwtHelper jwtHelper)
        {
            _context = context;
            _jwtHelper = jwtHelper;
        }

        public User Authenticate(string username, string password)
        {
            var user = _context.Users.SingleOrDefault(u => u.Username == username && u.Password == password);
            if (user == null)
                return null;

            return user;
        }

        public string GenerateJwtToken(User user)
        {
            return _jwtHelper.GenerateJwtToken(user);
        }
    }
}
