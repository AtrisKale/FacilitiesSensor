using FacilitiesSensor.Models;
using Microsoft.AspNetCore.Mvc;

namespace FacilitiesSensor.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Login()
        {
            return View(); // Renderiza Views/Account/Login.cshtml
        }

        [HttpPost]
        public IActionResult Login(Contraseña model)
        {
            if (ModelState.IsValid)
            {
                // Validación simple de ejemplo
                if (model.Username == "admin" && model.Password == "tgna1400")
                {
                    return RedirectToAction("Index", "Home");
                }

                ViewBag.ErrorMessage = "Contraseña equivocada. Intenta de nuevo.";

            }

            return View(model);
        }



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
                NivelActual = 45
            },

            new Tanque
            {
                Id = 2,
                Nombre = "Tanque B",
                NivelActual = 85
            }
        },

                Sensores = new List<Sensor>()
            };

            return View(modelo);
        }
    }
}