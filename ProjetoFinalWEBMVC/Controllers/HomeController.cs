using Microsoft.AspNetCore.Mvc;
using ProjetoFinalWEBMVC.Models;
using System.Diagnostics;

namespace ProjetoFinalWEBMVC.Controllers {
    public class HomeController: Controller {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }

        public IActionResult Index() {
            ViewData["Index"] = "Home teste ismael";
            ViewData["Email"] = "maelfons31@gmail.com";
            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}