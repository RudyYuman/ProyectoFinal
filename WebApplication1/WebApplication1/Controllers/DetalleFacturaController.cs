using Bussines_Layer;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class DetalleFacturaController : Controller
    {
        // GET: DetalleFactura
        public ActionResult Listar()
        {
            NegDetalleFactura obj = new NegDetalleFactura();
            return View(obj.Listar());
        }
        [HttpPost]
        public ActionResult Insertar(DetalleFacturaBO dto)
        {
            NegDetalleFactura obj = new NegDetalleFactura();
            obj.Insertar(dto);
            return RedirectToAction("Listar");
        }

        public ActionResult Eliminar(int id)
        {
            NegDetalleFactura obj = new NegDetalleFactura();
            obj.Eliminar(id);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Actualizar(DetalleFacturaBO dto)
        {
            NegDetalleFactura obj = new NegDetalleFactura();
            obj.Actualizar(dto);
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Actualizar(int ID)
        {
            NegDetalleFactura obj = new NegDetalleFactura();
            DetalleFacturaBO dto = obj.Listar().FirstOrDefault(a => a.ID_DETALLE_FACTURA == ID);
            return View("Actualizar", dto);
        }

        public ActionResult Insertar()
        {
            return View("insertar", new DetalleFacturaBO());
        }
    }
}