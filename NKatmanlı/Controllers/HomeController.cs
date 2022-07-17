using Microsoft.AspNetCore.Mvc;
using NKatmanlı.Models;
using System.Diagnostics;
using BLL;
using MODEL;

namespace NKatmanlı.Controllers
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
            User user = new User();
            user.Id = 1;
            user.Username = "FUR";
            user.NameSurname = "FURKAN GOUNUL";
            user.Password = "GALATASARAY";
           
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