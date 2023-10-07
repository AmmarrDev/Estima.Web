using Estima.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Estima.Web.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Expertise()
        {
            return View();
        }

        public IActionResult  ProjectTypes()
        {
            return View();
        }

        public IActionResult SoftwareExcellence()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Commitment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ContactForm()
        {
            return View("ContactForm");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}