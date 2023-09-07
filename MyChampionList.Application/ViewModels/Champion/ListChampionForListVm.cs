using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChampionList.Application.ViewModels.Champion
{
    public class ListChampionForListVm
    {
        public List<ChampionForListVm> Champions { get; set; }
        public int Count { get; set; }
    }
}
