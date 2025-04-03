using System.Security.Cryptography;
using System.Text;
using CustomerRelations.Data;
using CustomerRelations.Models;

namespace CustomerRelations.Services
{
    public class AuthService
    {
        private readonly CustomerRelationsContext _context;

        public AuthService(CustomerRelationsContext context)
        {
            _context = context;
        }

        public Admin? Authenticate(string username, string password)
        {
            var admin = _context.Admins.FirstOrDefault(a => a.Username == username);
            if (admin == null) return null;

            var hash = HashPassword(password);
            return admin.PasswordHash == hash ? admin : null;
        }

        public static string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(password);
            var hash = sha256.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}