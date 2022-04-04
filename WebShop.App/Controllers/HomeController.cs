using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using WebShop.App.Models;
using WebShop.Core.Enumerations;
using WebShop.Core.Services;

namespace WebShop.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SwichDBService swichDBService;
        public HomeController(ILogger<HomeController> logger, SwichDBService _swichDBService)
        {
            _logger = logger;
            swichDBService = _swichDBService;
        }

        public IActionResult Index()
        {
            @ViewBag.DB = swichDBService.Repository.ToString();

            return View();
        }

        public IActionResult SwitchDB()
        {

            swichDBService.Repository = swichDBService.Repository.Equals(Repository.InMemory) ? Repository.SqlServer : Repository.InMemory;

            @ViewBag.DB = swichDBService.Repository.ToString();

            return RedirectToAction("List", "Product");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
