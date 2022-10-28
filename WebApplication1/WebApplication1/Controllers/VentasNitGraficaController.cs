using Bussines_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class VentasNitGraficaController : Controller
    {
        // GET: VentasNitGrafica
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult DataPastel()
        {
            NegVentasNitGrafica list = new NegVentasNitGrafica();

            return this.Json(list.Listar(), JsonRequestBehavior.AllowGet);
            //return Json(list.Listar());

        }
    }
}