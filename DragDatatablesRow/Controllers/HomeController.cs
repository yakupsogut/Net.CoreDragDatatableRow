using DragDatatablesRow.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DragDatatablesRow.Controllers
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
        public IActionResult DragTableRowsPostExample()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DragTableRowsPostExample(List<string> order, List<string> fullName)
        {
            //You can now process incoming data
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}