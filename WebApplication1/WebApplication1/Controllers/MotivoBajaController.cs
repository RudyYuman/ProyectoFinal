using Bussines_Layer;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class MotivoBajaController : Controller
    {
        // GET: MotivoBaja
        public ActionResult Listar()
        {
            NegMotivoBaja obj = new NegMotivoBaja();
            return View(obj.Listar());
        }
        [HttpPost]
        public ActionResult Insertar(MotivoBajaBO dto)
        {
            NegMotivoBaja obj = new NegMotivoBaja();
            obj.Insertar(dto);
            return RedirectToAction("Listar");
        }

        public ActionResult Eliminar(int id)
        {
            NegMotivoBaja obj = new NegMotivoBaja();
            obj.Eliminar(id);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Actualizar(MotivoBajaBO dto)
        {
            NegMotivoBaja obj = new NegMotivoBaja();
            obj.Actualizar(dto);
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Actualizar(int ID)
        {
            NegMotivoBaja obj = new NegMotivoBaja();
            MotivoBajaBO dto = obj.Listar().FirstOrDefault(a => a.ID_BAJA == ID);
            return View("Actualizar", dto);
        }

        public ActionResult Insertar()
        {
            return View("insertar", new MotivoBajaBO());
        }
    }
}