using Bussines_Layer;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Listar()
        {
            NegEmpleado obj = new NegEmpleado();
            return View(obj.Listar());
        }
        [HttpPost]
        public ActionResult Insertar(EmpleadoBO dto)
        {
            NegEmpleado obj = new NegEmpleado();
            obj.Insertar(dto);
            return RedirectToAction("Listar");
        }

        public ActionResult Eliminar(int id)
        {
            NegEmpleado obj = new NegEmpleado();
            obj.Eliminar(id);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Actualizar(EmpleadoBO dto)
        {
            NegEmpleado obj = new NegEmpleado();
            obj.Actualizar(dto);
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Actualizar(int ID)
        {
            NegEmpleado obj = new NegEmpleado();
            EmpleadoBO dto = obj.Listar().FirstOrDefault(a => a.Id_EMPLEADO == ID);
            return View("Actualizar", dto);
        }

        public ActionResult Insertar()
        {
            return View("insertar", new EmpleadoBO());
        }
    }
}