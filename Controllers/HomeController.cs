using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DDLSWebApp.Models;
using Microsoft.Extensions.Configuration;



namespace DDLSWebApp.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration Configuration;
 
        public HomeController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        public IActionResult Index()
        {
            int valueToCube=0;
            int.TryParse(Request.Query["number"],out valueToCube);
            ViewBag.Number=valueToCube;
            //ViewBag.Result=MathService.Class1.Cube(valueToCube);
            ViewBag.Result="**Placeholder**";
            ViewBag.Colour = Configuration["Colour"];
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
