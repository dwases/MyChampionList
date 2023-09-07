using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyChampionList.Application.Mapping;

namespace MyChampionList.Application.ViewModels.Champion
{
    public class ChampionDetailsVm : IMapFrom<MyChampionList.Domain.Model.Champion>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public int RoleId { get; set; }
        public int TrueLoveCounter { get; set; }
        public int LikedCounter { get; set; }
        public int TrashedCounter { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<MyChampionList.Domain.Model.Champion, ChampionForListVm>();
        }
    }
}
