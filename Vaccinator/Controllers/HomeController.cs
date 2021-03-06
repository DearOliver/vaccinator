using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Vaccinator.Models;

namespace Vaccinator.Controllers
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

        public IActionResult Personnes()
        {
            //Model building
            var headers = Request.Headers.ToDictionary(item => item.Key, item => item.Value.ToList());

            //Return the view
            return View(headers);
        }

        public IActionResult VaccinTypes()
        {
            //Model building
            var headers = Request.Headers.ToDictionary(item => item.Key, item => item.Value.ToList());

            //Return the view
            return View(headers);
        }

        public IActionResult Injections()
        {
            //Model building
            var headers = Request.Headers.ToDictionary(item => item.Key, item => item.Value.ToList());

            //Return the view
            return View(headers);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
