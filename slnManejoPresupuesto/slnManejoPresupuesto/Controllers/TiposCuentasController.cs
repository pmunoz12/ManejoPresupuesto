using Microsoft.AspNetCore.Mvc;
using slnManejoPresupuesto.Models;

namespace slnManejoPresupuesto.Controllers
{
    public class TiposCuentasController : Controller
    {
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(TipoCuenta tipoCuenta)
        {
            if (!ModelState.IsValid)
            {
                return View(tipoCuenta);
            }    
            return View();
        }
    }
}
