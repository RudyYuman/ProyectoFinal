using Bussines_Layer;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class LineaController : Controller
    {
        // GET: Linea
        public ActionResult Listar()
        {
            NegLinea obj = new NegLinea();
            return View(obj.Listar());
        }
        [HttpPost]
        public ActionResult Insertar(LineaBO dto)
        {
            NegLinea obj = new NegLinea();
            obj.Insertar(dto);
            return RedirectToAction("Listar");
        }

        public ActionResult Eliminar(int id)
        {
            NegLinea obj = new NegLinea();
            obj.Eliminar(id);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Actualizar(LineaBO dto)
        {
            NegLinea obj = new NegLinea();
            obj.Actualizar(dto);
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Actualizar(int ID)
        {
            NegLinea obj = new NegLinea();
            LineaBO dto = obj.Listar().FirstOrDefault(a => a.ID_LINEA == ID);
            return View("Actualizar", dto);
        }

        public ActionResult Insertar()
        {
            return View("insertar", new LineaBO());
        }
    }
}