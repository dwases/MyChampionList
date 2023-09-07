using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyChampionList.Domain.Model;

namespace MyChampionList.Infrastructure.Repositories
{
    public class RoleRepository
    {
        private readonly Context _context;
        public RoleRepository(Context context)
        {
            _context = context;
        }

        public void DeleteRole(int roleId)
        {
            var role = _context.Roles.Find(roleId);
            if (role != null)
            {
                _context.Roles.Remove(role);
                _context.SaveChanges();
            }
        }
        public int AddRole(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
            return role.Id;
        }
        public Role GetRoleById(int roleId)
        {
            return _context.Roles.FirstOrDefault(i => i.Id == roleId);
        }
    }
}
