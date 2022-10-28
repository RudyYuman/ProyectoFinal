using Bussines_Layer;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ServicioProveedorController : Controller
    {
        // GET: ServicioProveedor
        public ActionResult Listar()
        {
            NegServicioProveedor obj = new NegServicioProveedor();
            return View(obj.Listar());
        }
        [HttpPost]
        public ActionResult Insertar(ServicioProveedorBO dto)
        {
            NegServicioProveedor obj = new NegServicioProveedor();
            obj.Insertar(dto);
            return RedirectToAction("Listar");
        }

        public ActionResult Eliminar(int id)
        {
            NegServicioProveedor obj = new NegServicioProveedor();
            obj.Eliminar(id);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Actualizar(ServicioProveedorBO dto)
        {
            NegServicioProveedor obj = new NegServicioProveedor();
            obj.Actualizar(dto);
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Actualizar(int ID)
        {
            NegServicioProveedor obj = new NegServicioProveedor();
            ServicioProveedorBO dto = obj.Listar().FirstOrDefault(a => a.ID_PRODUCTO_PROVEEDOR == ID);
            return View("Actualizar", dto);
        }

        public ActionResult Insertar()
        {
            return View("insertar", new ServicioProveedorBO());
        }
    }
}