using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyChampionList.Web.Models;

namespace MyChampionList.Web.Controllers
{
    public class ChampionsController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ChampionsController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index(int id)
        {
            List<Champion> lc = ListOfChampions.champions.Where(p => p.Id == id).ToList();
            return View(lc);
        }
        public IActionResult ViewListOfAllChampions(int id)
        {
            List<Champion> champions = new List<Champion>();
            champions.Add(new Champion() { Id = 1, Name = "Azir" });
            champions.Add(new Champion() { Id = 2, Name = "Renekton" });
            champions.Add(new Champion() { Id = 3, Name = "Sivir" });
            ListOfChampions.champions = champions;
            return View(champions);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
