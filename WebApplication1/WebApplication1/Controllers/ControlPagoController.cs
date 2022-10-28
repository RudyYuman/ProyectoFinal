using Bussines_Layer;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ControlPagoController : Controller
    {
        // GET: ControlPago
        public ActionResult Listar()
        {
            NegControlPago obj = new NegControlPago();
            return View(obj.Listar());
        }
        [HttpPost]
        public ActionResult Insertar(ControlPagoBO dto)
        {
            NegControlPago obj = new NegControlPago();
            obj.Insertar(dto);
            return RedirectToAction("Listar");
        }

        public ActionResult Eliminar(int id)
        {
            NegControlPago obj = new NegControlPago();
            obj.Eliminar(id);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Actualizar(ControlPagoBO dto)
        {
            NegControlPago obj = new NegControlPago();
            obj.Actualizar(dto);
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Actualizar(int ID)
        {
            NegControlPago obj = new NegControlPago();
            ControlPagoBO dto = obj.Listar().FirstOrDefault(a => a.ID_CONTROL_PAGO == ID);
            return View("Actualizar", dto);
        }

        public ActionResult Insertar()
        {
            return View("insertar", new ControlPagoBO());
        }
    }
}