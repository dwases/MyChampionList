using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyChampionList.Application.Interfaces;
using MyChampionList.Web.Models;

namespace MyChampionList.Web.Controllers
{
    public class ChampionController : Controller
    {
        private readonly IChampionService _champService;
        public ChampionController(IChampionService champService)
        {
            _champService = champService;
        }
        public IActionResult Index()
        {
            //create view for the action
            //tabela z championami
            //filtrowanie championów
            //przygotować dane
            //serwis musi przygotować
            //serwis musi zwrócić dane

            var model = _champService.GetChampionsForList();
            return View(model);
        }
        
        [HttpGet]
        public IActionResult AddChampion()
        {
            return View();
        }
        /*
        [HttpPost]
        public IActionResult AddChampion(ChampionModel model)
        {
            var id = championService.AddChampion(model);
            return View();
        }

        [HttpGet]
        public IActionResult AddRoleForChampion(int championId)
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddRoleForChampion(ChampionModel model)
        {
            return View();
        }

        public IActionResult ViewChampion(int championId)
        {
            var championModel = championService.GetChampion(championId);
            return View(championModel);
        }
        */
    }
}
