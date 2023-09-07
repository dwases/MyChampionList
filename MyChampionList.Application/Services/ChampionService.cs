using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MyChampionList.Application.Interfaces;
using MyChampionList.Application.ViewModels.Champion;
using MyChampionList.Domain.Interfaces;

namespace MyChampionList.Application.Services
{
    internal class ChampionService : IChampionService
    {
        private readonly IChampionRepository _championRepo;
        private readonly IMapper _mapper;
        public ChampionService(IChampionRepository championRepo, IMapper mapper)
        {
            _championRepo = championRepo;
            _mapper = mapper;
        }

        public int AddChampion(NewChampionVm model)
        {
            throw new NotImplementedException();
        }

        public ChampionDetailsVm GetChampion(int championId)
        {
            //handmade solution
            /*
            var champion = _championRepo.GetChampionById(championId);
            var championVm = new ChampionDetailsVm();
            championVm.Id = champion.Id;
            championVm.Name = champion.Name;
            championVm.RoleId = champion.RoleId;
            championVm.Description = champion.Description;
            return championVm;
            */
            //automapper solution
            var champion = _championRepo.GetChampionById(championId);
            var championVm = _mapper.Map<ChampionDetailsVm>(champion);
            return championVm;
        }

        public ListChampionForListVm GetChampionsForList()
        {
            //handmade solution
            /*
            var champions = _championRepo.GetAllChampions();
            ListChampionForListVm result = new ListChampionForListVm();
            result.Champions = new List<ChampionForListVm>();
            foreach (var champion in champions)
            {
                var champVm = new ChampionForListVm()
                {
                    Id = champion.Id,
                    Name = champion.Name,
                    RoleId = champion.RoleId
                };
                result.Champions.Add(champVm);
            }
            result.Count = result.Champions.Count;
            return result;
            */

            //automapper solution
            var champions = _championRepo.GetAllChampions()
                .ProjectTo<ChampionForListVm>(_mapper.ConfigurationProvider).ToList();
            var championList = new ListChampionForListVm()
            {
                Champions = champions,
                Count = champions.Count
            };
            return championList;
        }
    }
}
