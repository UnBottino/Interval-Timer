using Interval_Timer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Interval_Timer.Controllers
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

        [HttpPost]
        public IActionResult Index(Info info)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(Workout), info);
            }

            return View(info);
        }

        public IActionResult Workout(Info info)
        {
            return View(info);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
