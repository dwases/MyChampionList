using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyChampionList.Web.Models;

namespace MyChampionList.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public UsersController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //
        [HttpGet]
        public IActionResult Index(int id)
        {
            List<User> lu = ListOfUsers.users.Where(p => p.Id == id).ToList();
            return View(lu);
        }
        public IActionResult ViewListOfAllUsers(int id)
        {
            List<User> users = new List<User>();
            users.Add(new User() { Id = 1, Username = "User1" });
            users.Add(new User() { Id = 2, Username = "second user" });
            users.Add(new User() { Id = 3, Username = "usr the 3rd" });
            ListOfUsers.users = users;
            return View(users);
        }
        //
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
