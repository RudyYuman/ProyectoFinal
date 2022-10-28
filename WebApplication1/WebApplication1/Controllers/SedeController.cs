using Bussines_Layer;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class SedeController : Controller
    {
        // GET: Sede
        public ActionResult Listar()
        {
            NegSede obj = new NegSede();
            return View(obj.Listar());
        }
        [HttpPost]
        public ActionResult Insertar(SedeBO dto)
        {
            NegSede obj = new NegSede();
            obj.Insertar(dto);
            return RedirectToAction("Listar");
        }

        public ActionResult Eliminar(int id)
        {
            NegSede obj = new NegSede();
            obj.Eliminar(id);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Actualizar(SedeBO dto)
        {
            NegSede obj = new NegSede();
            obj.Actualizar(dto);
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Actualizar(int ID)
        {
            NegSede obj = new NegSede();
            SedeBO dto = obj.Listar().FirstOrDefault(a => a.ID_SEDE == ID);
            return View("Actualizar", dto);
        }

        public ActionResult Insertar()
        {
            return View("insertar", new SedeBO());
        }
    }
}