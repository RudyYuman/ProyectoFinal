using Bussines_Layer;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class VehiculoController : Controller
    {
        // GET: Vehiculo
        public ActionResult Listar()
        {
            NegVehiculo obj = new NegVehiculo();
            return View(obj.Listar());
        }
        [HttpPost]
        public ActionResult Insertar(VehiculoBO dto)
        {
            NegVehiculo obj = new NegVehiculo();
            obj.Insertar(dto);
            return RedirectToAction("Listar");
        }

        public ActionResult Eliminar(int id)
        {
            NegVehiculo obj = new NegVehiculo();
            obj.Eliminar(id);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Actualizar(VehiculoBO dto)
        {
            NegVehiculo obj = new NegVehiculo();
            obj.Actualizar(dto);
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Actualizar(int ID)
        {
            NegVehiculo obj = new NegVehiculo();
            VehiculoBO dto = obj.Listar().FirstOrDefault(a => a.ID_VEHICULO == ID);
            return View("Actualizar", dto);
        }

        public ActionResult Insertar()
        {
            return View("insertar", new VehiculoBO());
        }
    }
}