using Bussines_Layer;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TipoProductoController : Controller
    {
        // GET: TipoProducto
        public ActionResult Listar()
        {
            NegTipoProducto obj = new NegTipoProducto();
            return View(obj.Listar());
        }
        [HttpPost]
        public ActionResult Insertar(TipoProductoBO dto)
        {
            NegTipoProducto obj = new NegTipoProducto();
            obj.Insertar(dto);
            return RedirectToAction("Listar");
        }

        public ActionResult Eliminar(int id)
        {
            NegTipoProducto obj = new NegTipoProducto();
            obj.Eliminar(id);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Actualizar(TipoProductoBO dto)
        {
            NegTipoProducto obj = new NegTipoProducto();
            obj.Actualizar(dto);
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Actualizar(int ID)
        {
            NegTipoProducto obj = new NegTipoProducto();
            TipoProductoBO dto = obj.Listar().FirstOrDefault(a => a.ID_TIPO_PRODUCTO == ID);
            return View("Actualizar", dto);
        }

        public ActionResult Insertar()
        {
            return View("insertar", new TipoProductoBO());
        }
    }
}