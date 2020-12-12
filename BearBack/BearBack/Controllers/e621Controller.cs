using System.Diagnostics;
using BearBack.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BearBack.Controllers
{
    public class e621Controller : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        private readonly ILogger<e621Controller> _logger;

        public e621Controller(ILogger<e621Controller> logger, IWebHostEnvironment webHost)
        {
            _logger = logger;
            _webHost = webHost;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        
        /// <summary>
        /// Default error view
        /// </summary>
        /// <returns>Generic error page</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}