using itvitea_Restaurant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using DataProcessor;
using System.Collections.Generic;

namespace itvitea_Restaurant.Controllers
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
            Order newOrder = new Order();

            var dbreturndata = Connection.List<Order> ("Order");
            var dbreturndata2 = Connection.Update<Order>(newOrder, "Order", new string[] { "Id" }, new string[] { "0" });
            var dbreturndata3 = Connection.List("Order");

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
