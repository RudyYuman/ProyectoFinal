using Bussines_Layer;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Listar()
        {
            NegCliente obj = new NegCliente();
            return View(obj.Listar());
        }
        [HttpPost]
        public ActionResult Insertar(ClienteBO dto)
        {
            NegCliente obj = new NegCliente();
            obj.Insertar(dto);
            return RedirectToAction("Listar");
        }
        
        public ActionResult Eliminar(int id)
        {
            NegCliente obj = new NegCliente();
            obj.Eliminar(id);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Actualizar(ClienteBO dto)
        {
            NegCliente obj = new NegCliente();
            obj.Actualizar(dto);
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Actualizar(int ID) 
        {
            NegCliente obj = new NegCliente();
            ClienteBO dto = obj.Listar().FirstOrDefault(a=> a.Id_CLIENTE == ID);
            return View("Actualizar", dto) ;
        }
                
        public ActionResult Insertar()
        {            
            return View("insertar", new ClienteBO());
        }

    }
}