using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyChampionList.Domain.Interfaces;
using MyChampionList.Domain.Model;

namespace MyChampionList.Infrastructure.Repositories
{
    public class ChampionRepository : IChampionRepository
    {
        private readonly Context _context;
        public ChampionRepository(Context context)
        {
            _context = context;
        }

        //methods to work with champions like a service does
        public void DeleteChampion(int championId)
        {
            var champion = _context.Champions.Find(championId);
            if (champion != null)
            {
                _context.Champions.Remove(champion);
                _context.SaveChanges();
            }
        }
        public int AddChampion(Champion champion)
        {
            _context.Champions.Add(champion);
            _context.SaveChanges();
            return champion.Id;
        }
        public IQueryable<Champion> GetChampionsByRoleId(int roleId)
        {
            return _context.Champions.Where(c => c.RoleId == roleId);
        }
        public Champion GetChampionById(int champId)
        {
            return _context.Champions.FirstOrDefault(i => i.Id == champId);
        }

        public IQueryable<Champion> GetAllChampions()
        {
            return _context.Champions.Where(i => i.Id != null);
        }
    }
}
