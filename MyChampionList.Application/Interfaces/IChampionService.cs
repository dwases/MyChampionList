using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyChampionList.Application.ViewModels.Champion;

namespace MyChampionList.Application.Interfaces
{
    public interface IChampionService
    {
        ListChampionForListVm GetChampionsForList();
        int AddChampion(NewChampionVm model);
        ChampionDetailsVm GetChampion(int championId);
    }
}
