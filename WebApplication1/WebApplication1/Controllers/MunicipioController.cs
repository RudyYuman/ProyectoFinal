using Bussines_Layer;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class MunicipioController : Controller
    {
        // GET: Municipio
        public ActionResult Listar()
        {
            NegMunicipio obj = new NegMunicipio();
            return View(obj.Listar());
        }
        [HttpPost]
        public ActionResult Insertar(MunicipioBO dto)
        {
            NegMunicipio obj = new NegMunicipio();
            obj.Insertar(dto);
            return RedirectToAction("Listar");
        }

        public ActionResult Eliminar(int id)
        {
            NegMunicipio obj = new NegMunicipio();
            obj.Eliminar(id);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Actualizar(MunicipioBO dto)
        {
            NegMunicipio obj = new NegMunicipio();
            obj.Actualizar(dto);
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Actualizar(int ID)
        {
            NegMunicipio obj = new NegMunicipio();
            MunicipioBO dto = obj.Listar().FirstOrDefault(a => a.ID_MUNICIPIO == ID);
            return View("Actualizar", dto);
        }

        public ActionResult Insertar()
        {
            return View("insertar", new MunicipioBO());
        }
    }
}