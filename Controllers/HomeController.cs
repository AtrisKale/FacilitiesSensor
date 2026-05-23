using FacilitiesSensor.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FacilitiesSensor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var modelo = new TanqueSUF
            {
                NivelActual = 100 // ejemplo, 70%
            };
            return View(modelo);
            
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
