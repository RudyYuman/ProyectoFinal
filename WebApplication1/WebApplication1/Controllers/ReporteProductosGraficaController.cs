using Bussines_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ReporteProductosGraficaController : Controller
    {
        // GET: ReporteProductosGrafica
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult DataPastel()
        {
            NegReporteProductosGrafica list = new NegReporteProductosGrafica();

            return this.Json(list.Listar(), JsonRequestBehavior.AllowGet);
            //return Json(list.Listar());

        }
    }
}