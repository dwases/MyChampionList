using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyChampionList.Domain.Model;

namespace MyChampionList.Domain.Interfaces
{
    public interface IRoleRepository
    {
        void DeleteRole(int roleId);
        int AddRole(Role role);
        Role GetRoleById(int roleId);
    }
}
