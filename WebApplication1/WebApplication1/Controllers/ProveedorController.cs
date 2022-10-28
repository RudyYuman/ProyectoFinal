using Bussines_Layer;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ProveedorController : Controller
    {
        // GET: Proveedor
        public ActionResult Listar()
        {
            NegProveedor obj = new NegProveedor();
            return View(obj.Listar());
        }
        [HttpPost]
        public ActionResult Insertar(ProveedorBO dto)
        {
            NegProveedor obj = new NegProveedor();
            obj.Insertar(dto);
            return RedirectToAction("Listar");
        }

        public ActionResult Eliminar(int id)
        {
            NegProveedor obj = new NegProveedor();
            obj.Eliminar(id);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Actualizar(ProveedorBO dto)
        {
            NegProveedor obj = new NegProveedor();
            obj.Actualizar(dto);
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Actualizar(int ID)
        {
            NegProveedor obj = new NegProveedor();
            ProveedorBO dto = obj.Listar().FirstOrDefault(a => a.ID_PROVEEDOR == ID);
            return View("Actualizar", dto);
        }

        public ActionResult Insertar()
        {
            return View("insertar", new ProveedorBO());
        }
    }
}