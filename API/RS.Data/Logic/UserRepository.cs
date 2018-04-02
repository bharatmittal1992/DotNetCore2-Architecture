using RS.Data.Interfaces;
using RS.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace RS.Data.Logic
{
    public class UserRepository : Repository<Users>, IUserRepository
    {
        private readonly RSContext _context;
        public UserRepository(RSContext context) : base(context)
        {
            this._context = context;
        }

        public Users LoginUser(string username, string password)
        {
            return _context.Users.Include(t => t.UserRoles).ThenInclude(r => r.Role).FirstOrDefault(x => x.UserName == username && x.Password == password);
        }
    }
}
