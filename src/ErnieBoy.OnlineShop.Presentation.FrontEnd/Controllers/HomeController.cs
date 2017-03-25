using Microsoft.AspNetCore.Mvc;
using ErnieBoy.OnlineShop.Application.Abstractions.Services;

namespace ErnieBoy.OnlineShop.Presentation.FrontEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILoggingService _loggingService;
        public HomeController(ILoggingService loggingService)
        {
            _loggingService = loggingService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
