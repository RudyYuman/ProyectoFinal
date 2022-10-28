using Bussines_Layer;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class FacturaController : Controller
    {
        // GET: Factura
        public ActionResult Listar()
        {
            NegFactura obj = new NegFactura();
            return View(obj.Listar());
        }
        [HttpPost]
        public ActionResult Insertar(FacturaBO dto)
        {
            NegFactura obj = new NegFactura();
            obj.Insertar(dto);
            return RedirectToAction("Listar");
        }

        public ActionResult Eliminar(int id)
        {
            NegFactura obj = new NegFactura();
            obj.Eliminar(id);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Actualizar(FacturaBO dto)
        {
            NegFactura obj = new NegFactura();
            obj.Actualizar(dto);
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Actualizar(int ID)
        {
            NegFactura obj = new NegFactura();
            FacturaBO dto = obj.Listar().FirstOrDefault(a => a.ID_VENTA == ID);
            return View("Actualizar", dto);
        }

        public ActionResult Insertar()
        {
            return View("insertar", new FacturaBO());
        }
    }
}