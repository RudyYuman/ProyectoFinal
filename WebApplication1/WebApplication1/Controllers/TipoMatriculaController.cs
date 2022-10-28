using Bussines_Layer;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TipoMatriculaController : Controller
    {
        // GET: TipoMatricula
        public ActionResult Listar()
        {
            NegTipoMatricula obj = new NegTipoMatricula();
            return View(obj.Listar());
        }
        [HttpPost]
        public ActionResult Insertar(TipoMatriculaBO dto)
        {
            NegTipoMatricula obj = new NegTipoMatricula();
            obj.Insertar(dto);
            return RedirectToAction("Listar");
        }

        public ActionResult Eliminar(int id)
        {
            NegTipoMatricula obj = new NegTipoMatricula();
            obj.Eliminar(id);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Actualizar(TipoMatriculaBO dto)
        {
            NegTipoMatricula obj = new NegTipoMatricula();
            obj.Actualizar(dto);
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Actualizar(int ID)
        {
            NegTipoMatricula obj = new NegTipoMatricula();
            TipoMatriculaBO dto = obj.Listar().FirstOrDefault(a => a.ID_TIPO_MATRICULA == ID);
            return View("Actualizar", dto);
        }

        public ActionResult Insertar()
        {
            return View("insertar", new TipoMatriculaBO());
        }
    }
}