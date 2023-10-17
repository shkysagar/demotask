using System.Diagnostics;
using DemoProject.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DemoProject.Controllers
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
        [HttpGet("GetProductListing")]
        public IActionResult GetProductLists()
        {
            var products = JsonConvert.DeserializeObject<List<Product>>(DemoProject.Constants.Demo.DEMO_PRODUCTS);
            return Json(products);
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