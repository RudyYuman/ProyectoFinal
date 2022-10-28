using Bussines_Layer;
using Dataacces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult DataPastel()
        {
            NegSeriePastel list = new NegSeriePastel();

            return this.Json(list.Listar(), JsonRequestBehavior.AllowGet);
            //return Json(list.Listar());

        }
    }
}