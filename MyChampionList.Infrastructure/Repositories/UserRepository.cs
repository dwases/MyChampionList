using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyChampionList.Domain.Model;

namespace MyChampionList.Infrastructure.Repositories
{
    public class UserRepository
    {
        private readonly Context _context;
        public UserRepository(Context context)
        {
            _context = context;
        }
        //new lines
        public void DeleteUser(int userId)
        {
            var user = _context.Users.Find(userId);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }
        public int AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.Id;
        }
        public IQueryable<User> GetUsersByTrueLoveId(int trueLoveId)
        {
            return _context.Users.Where(u => u.TrueLoveId == trueLoveId);
        }
        public User GetUserById(int userId)
        {
            return _context.Users.FirstOrDefault(i => i.Id == userId);
        }
    }
}
