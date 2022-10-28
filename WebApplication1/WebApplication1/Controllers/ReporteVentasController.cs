using Bussines_Layer;
using Rotativa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ReporteVentasController : Controller
    {
        // GET: ReporteVentas
        public ActionResult Print()
        {
            return new ActionAsPdf("Listar", new { nombre = "Reporte" }) { FileName = "Ventas.pdf" };
        }

        public ActionResult Listar()
        {
            NegDetalleVentasReport obj = new NegDetalleVentasReport();
            return View(obj.Listar());
        }
    }
}