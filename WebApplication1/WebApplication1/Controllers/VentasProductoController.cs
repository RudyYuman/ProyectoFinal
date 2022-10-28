using Dataacces;
using Rotativa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class VentasProductoController : Controller
    {
        // GET: VentasProducto
        public ActionResult Print()
        {
            return new ActionAsPdf("Listar", new { nombre = "Reporte" }) { FileName = "ProductosVendidos.pdf" };
        }

        public ActionResult Listar()
        {
            daoVentasProducto obj = new daoVentasProducto();
            return View(obj.Listar());
        }
    }
}