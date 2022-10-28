using Bussines_Layer;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class DepartamentoController : Controller
    {
        // GET: Departamento
        public ActionResult Listar()
        {
            NegDepartamento obj = new NegDepartamento();
            return View(obj.Listar());
        }
        [HttpPost]
        public ActionResult Insertar(DepartamentoBO dto)
        {
            NegDepartamento obj = new NegDepartamento();
            obj.Insertar(dto);
            return RedirectToAction("Listar");
        }

        public ActionResult Eliminar(int id)
        {
            NegDepartamento obj = new NegDepartamento();
            obj.Eliminar(id);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Actualizar(DepartamentoBO dto)
        {
            NegDepartamento obj = new NegDepartamento();
            obj.Actualizar(dto);
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Actualizar(int ID)
        {
            NegDepartamento obj = new NegDepartamento();
            DepartamentoBO dto = obj.Listar().FirstOrDefault(a => a.ID_DEPARTAMENTO == ID);
            return View("Actualizar", dto);
        }

        public ActionResult Insertar()
        {
            return View("insertar", new DepartamentoBO());
        }
    }
}