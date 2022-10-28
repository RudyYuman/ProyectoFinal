using Dataacces;
using Rotativa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class VentasPorNitController : Controller
    {
        // GET: VentasPorNit
        public ActionResult Print()
        {
            return new ActionAsPdf("Listar", new { nombre = "Reporte" }) { FileName = "Ventas.pdf" };
        }

        public ActionResult Listar()
        {
            daoVentasPorNitCliente obj = new daoVentasPorNitCliente();
            return View(obj.Listar());
        }
    }
}