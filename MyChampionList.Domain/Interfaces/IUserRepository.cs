using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyChampionList.Domain.Model;

namespace MyChampionList.Domain.Interfaces
{
    public interface IUserRepository 
    {
        void DeleteUser(int userId);
        int AddUser(User user);
        IQueryable<User> GetUsersByTrueLoveId(int trueLoveId);
        User GetUserById(int userId);
    }
}
