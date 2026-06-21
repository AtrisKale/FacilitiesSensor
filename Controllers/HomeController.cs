using FacilitiesSensor.Models;
using Microsoft.AspNetCore.Mvc;

namespace FacilitiesSensor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var modelo = new DashboardViewModel
            {
                Tanques = new List<Tanque>
        {
            new Tanque
            {
                Id = 1,
                Nombre = "Tanque A",
                NivelActual = 50
            },

            new Tanque
            {
                Id = 2,
                Nombre = "Tanque B",
                NivelActual = 45
            }
        },

                Sensores = new List<Sensor>()
            };

            return View(modelo);
        }
    }
}