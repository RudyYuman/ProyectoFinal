using Bussines_Layer;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TurnoController : Controller
    {
        // GET: Turno
        public ActionResult Listar()
        {
            NegTurno obj = new NegTurno();
            return View(obj.Listar());
        }
        [HttpPost]
        public ActionResult Insertar(TurnoBO dto)
        {
            NegTurno obj = new NegTurno();
            obj.Insertar(dto);
            return RedirectToAction("Listar");
        }

        public ActionResult Eliminar(int id)
        {
            NegTurno obj = new NegTurno();
            obj.Eliminar(id);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Actualizar(TurnoBO dto)
        {
            NegTurno obj = new NegTurno();
            obj.Actualizar(dto);
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Actualizar(int ID)
        {
            NegTurno obj = new NegTurno();
            TurnoBO dto = obj.Listar().FirstOrDefault(a => a.Id_TURNO == ID);
            return View("Actualizar", dto);
        }

        public ActionResult Insertar()
        {
            return View("insertar", new TurnoBO());
        }
    }
}