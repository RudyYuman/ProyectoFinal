using Bussines_Layer;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TurnoEmpleadoController : Controller
    {
        // GET: TurnoEmpleado
        public ActionResult Listar()
        {
            NegTurnoEmpleado obj = new NegTurnoEmpleado();
            return View(obj.Listar());
        }
        [HttpPost]
        public ActionResult Insertar(TurnoEmpleadoBO dto)
        {
            NegTurnoEmpleado obj = new NegTurnoEmpleado();
            obj.Insertar(dto);
            return RedirectToAction("Listar");
        }

        public ActionResult Eliminar(int id)
        {
            NegTurnoEmpleado obj = new NegTurnoEmpleado();
            obj.Eliminar(id);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Actualizar(TurnoEmpleadoBO dto)
        {
            NegTurnoEmpleado obj = new NegTurnoEmpleado();
            obj.Actualizar(dto);
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Actualizar(int ID)
        {
            NegTurnoEmpleado obj = new NegTurnoEmpleado();
            TurnoEmpleadoBO dto = obj.Listar().FirstOrDefault(a => a.Id_TURNO_EMPLEADO == ID);
            return View("Actualizar", dto);
        }

        public ActionResult Insertar()
        {
            return View("insertar", new TurnoEmpleadoBO());
        }
    }
}