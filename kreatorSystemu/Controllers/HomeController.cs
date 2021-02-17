using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using kreatorSystemu.Models;

namespace kreatorSystemu.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Jak działa kreator systemu";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Strona kontaktowa";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult CreatorForms()
        {
            ViewData["Message"] = "Strona kreatatora systemu";
            return View();
        }

        public IActionResult Table()
        {
            ViewData["Message"] = "Wybrane pozycje";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
