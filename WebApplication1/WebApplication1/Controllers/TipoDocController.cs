using Bussines_Layer;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TipoDocController : Controller
    {
        // GET: TipoDoc
        public ActionResult Listar()
        {
            NegTipoDoc obj = new NegTipoDoc();
            return View(obj.Listar());
        }
        [HttpPost]
        public ActionResult Insertar(TipoDocBO dto)
        {
            NegTipoDoc obj = new NegTipoDoc();
            obj.Insertar(dto);
            return RedirectToAction("Listar");
        }

        public ActionResult Eliminar(int id)
        {
            NegTipoDoc obj = new NegTipoDoc();
            obj.Eliminar(id);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Actualizar(TipoDocBO dto)
        {
            NegTipoDoc obj = new NegTipoDoc();
            obj.Actualizar(dto);
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Actualizar(int ID)
        {
            NegTipoDoc obj = new NegTipoDoc();
            TipoDocBO dto = obj.Listar().FirstOrDefault(a => a.ID_TIPO_DOC == ID);
            return View("Actualizar", dto);
        }

        public ActionResult Insertar()
        {
            return View("insertar", new TipoDocBO());
        }
    }
}