using Bussines_Layer;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class SedeServicioController : Controller
    {
        // GET: SedeServicio
        //cambiar la clase a publica
        //copiar y pegar los metodos de NegCliente y cambiar los datos por los de tabla que estamos trabajando
        //Dar clic derecho sobre el metodo y en add view para crear la vista

        public ActionResult Listar()
        {
            NegSedeServicio obj = new NegSedeServicio();
            return View(obj.Listar());
        }
        [HttpPost]
        public ActionResult Insertar(SedeServicioBO dto)
        {
            NegSedeServicio obj = new NegSedeServicio();
            obj.Insertar(dto);
            return RedirectToAction("Listar");
        }

        public ActionResult Eliminar(int id)
        {
            NegSedeServicio obj = new NegSedeServicio();
            obj.Eliminar(id);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Actualizar(SedeServicioBO dto)
        {
            NegSedeServicio obj = new NegSedeServicio();
            obj.Actualizar(dto);
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Actualizar(int ID)
        {
            NegSedeServicio obj = new NegSedeServicio();
            SedeServicioBO dto = obj.Listar().FirstOrDefault(a => a.ID_SEDE_SERVICIO == ID);
            return View("Actualizar", dto);
        }

        public ActionResult Insertar()
        {
            return View("insertar", new SedeServicioBO());
        }
    }
}