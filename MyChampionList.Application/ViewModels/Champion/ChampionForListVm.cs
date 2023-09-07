using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyChampionList.Application.Mapping;
using MyChampionList.Domain.Model;

namespace MyChampionList.Application.ViewModels.Champion
{
    public class ChampionForListVm : IMapFrom<MyChampionList.Domain.Model.Champion>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RoleId { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<MyChampionList.Domain.Model.Champion, ChampionForListVm>();
                //.ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                //.ForMember(d => d.Name, opt => opt.MapFrom(s => s.Name))
                //.ForMember(d => d.RoleId, opt => opt.MapFrom(s => s.RoleId));
        }
    }
}
