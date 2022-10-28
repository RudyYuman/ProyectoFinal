using Bussines_Layer;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class MarcaController : Controller
    {
        // GET: Marca
        public ActionResult Listar()
        {
            NegMarca obj = new NegMarca();
            return View(obj.Listar());
        }
        [HttpPost]
        public ActionResult Insertar(MarcaBO dto)
        {
            NegMarca obj = new NegMarca();
            obj.Insertar(dto);
            return RedirectToAction("Listar");
        }

        public ActionResult Eliminar(int id)
        {
            NegMarca obj = new NegMarca();
            obj.Eliminar(id);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Actualizar(MarcaBO dto)
        {
            NegMarca obj = new NegMarca();
            obj.Actualizar(dto);
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Actualizar(int ID)
        {
            NegMarca obj = new NegMarca();
            MarcaBO dto = obj.Listar().FirstOrDefault(a => a.ID_MARCA == ID);
            return View("Actualizar", dto);
        }

        public ActionResult Insertar()
        {
            return View("insertar", new MarcaBO());
        }
    }
}