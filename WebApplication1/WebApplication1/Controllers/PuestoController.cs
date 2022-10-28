using Bussines_Layer;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class PuestoController : Controller
    {
        // GET: Puesto
        public ActionResult Listar()
        {
            NegPuesto obj = new NegPuesto();
            return View(obj.Listar());
        }
        [HttpPost]
        public ActionResult Insertar(PuestoBO dto)
        {
            NegPuesto obj = new NegPuesto();
            obj.Insertar(dto);
            return RedirectToAction("Listar");
        }

        public ActionResult Eliminar(int id)
        {
            NegPuesto obj = new NegPuesto();
            obj.Eliminar(id);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Actualizar(PuestoBO dto)
        {
            NegPuesto obj = new NegPuesto();
            obj.Actualizar(dto);
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Actualizar(int ID)
        {
            NegPuesto obj = new NegPuesto();
            PuestoBO dto = obj.Listar().FirstOrDefault(a => a.ID_PUESTO == ID);
            return View("Actualizar", dto);
        }

        public ActionResult Insertar()
        {
            return View("insertar", new PuestoBO());
        }
    }
}