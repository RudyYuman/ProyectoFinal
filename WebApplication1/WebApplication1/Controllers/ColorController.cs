using Bussines_Layer;
using Entity_Layer;
using Rotativa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ColorController : Controller
    {
        // GET: Color
        public ActionResult Listar()
        {
            NegColor obj = new NegColor();
            return View(obj.Listar());
        }
        [HttpPost]
        public ActionResult Insertar(ColorBO dto)
        {
            NegColor obj = new NegColor();
            obj.Insertar(dto);
            return RedirectToAction("Listar");
        }

        public ActionResult Eliminar(int id)
        {
            NegColor obj = new NegColor();
            obj.Eliminar(id);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Actualizar(ColorBO dto)
        {
            NegColor obj = new NegColor();
            obj.Actualizar(dto);
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Actualizar(int ID)
        {
            NegColor obj = new NegColor();
            ColorBO dto = obj.Listar().FirstOrDefault(a => a.ID_COLOR == ID);
            return View("Actualizar", dto);
        }

        public ActionResult Insertar()
        {
            return View("insertar", new ColorBO());
        }

        public ActionResult Print()
        {
            return new ActionAsPdf("Listar", new { nombre = "Reporte" }) { FileName = "Test.pdof" };
        }
    }
}