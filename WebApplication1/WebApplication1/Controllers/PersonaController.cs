using Bussines_Layer;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Listar()
        {
            NegPersona obj = new NegPersona();
            return View(obj.Listar());
        }
        [HttpPost]
        public ActionResult Insertar(PersonaBO dto)
        {
            NegPersona obj = new NegPersona();
            obj.Insertar(dto);
            return RedirectToAction("Listar");
        }

        public ActionResult Eliminar(int id)
        {
            NegPersona obj = new NegPersona();
            obj.Eliminar(id);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Actualizar(PersonaBO dto)
        {
            NegPersona obj = new NegPersona();
            obj.Actualizar(dto);
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Actualizar(int ID)
        {
            NegPersona obj = new NegPersona();
            PersonaBO dto = obj.Listar().FirstOrDefault(a => a.Id_persona == ID);
            return View("Actualizar", dto);
        }

        public ActionResult Insertar()
        {
            return View("insertar", new PersonaBO());
        }
    }
}