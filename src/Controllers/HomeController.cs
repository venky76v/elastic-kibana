using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using elastic_kibana.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace elastic_kibana.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;
        public HomeController (ILogger<HomeController> logger) {
            _logger = logger;
        }
        public IActionResult Index () {
            _logger.LogInformation($"oh hai there! : {DateTime.UtcNow}");
            return View ();
        }

        public IActionResult Privacy () {
            try {
                throw new Exception("oops... something really bad happened there!!!");
            }
            catch (Exception ex) {
                _logger.LogError($"ex, your code is buggy {ex.StackTrace} ");
            }
            return View ();
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}