using Microsoft.AspNetCore.Mvc;
using project_.Models;
using System.Diagnostics;

namespace project_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult News()
        {
            return View();
        }

        public IActionResult Jobs()
        {
            return View();
        }

        public IActionResult Facilite()
        {
            return View();
        }


        public IActionResult Mission()
        {
            return View();
        }

        public IActionResult Foundation()
        {
            return View();
        }

        public IActionResult Membership()
        {
            return View();

        }

        public IActionResult BoardDirect()
        {

            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}