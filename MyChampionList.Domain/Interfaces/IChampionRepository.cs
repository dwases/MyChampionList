using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyChampionList.Domain.Model;

namespace MyChampionList.Domain.Interfaces
{
    public interface IChampionRepository
    {
        void DeleteChampion(int championId);
        int AddChampion(Champion champion);
        IQueryable<Champion> GetChampionsByRoleId(int roleId);
        Champion GetChampionById(int champId);
        IQueryable<Champion> GetAllChampions();
    }
}
