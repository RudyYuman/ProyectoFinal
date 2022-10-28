using Bussines_Layer;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class EstadoController : Controller
    {
        // GET: Estado
        public ActionResult Listar()
        {
            NegEstado obj = new NegEstado();
            return View(obj.Listar());
        }
        [HttpPost]
        public ActionResult Insertar(EstadoBO dto)
        {
            NegEstado obj = new NegEstado();
            obj.Insertar(dto);
            return RedirectToAction("Listar");
        }

        public ActionResult Eliminar(int id)
        {
            NegEstado obj = new NegEstado();
            obj.Eliminar(id);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Actualizar(EstadoBO dto)
        {
            NegEstado obj = new NegEstado();
            obj.Actualizar(dto);
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Actualizar(int ID)
        {
            NegEstado obj = new NegEstado();
            EstadoBO dto = obj.Listar().FirstOrDefault(a => a.Id_ESTADO == ID);
            return View("Actualizar", dto);
        }

        public ActionResult Insertar()
        {
            return View("insertar", new EstadoBO());
        }
    }
}