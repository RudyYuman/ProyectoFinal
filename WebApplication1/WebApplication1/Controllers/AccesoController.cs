using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class AccesoController : Controller
    {
     public string strOracle = "";

        // GET: Acceso
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Usuario oUsuario)
        {

            oUsuario.Password = oUsuario.Password;

            strOracle = "User Id="+oUsuario.Nombre_Usuario+"; Password=" + oUsuario.Password + " ; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-QLMB4K6)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = XE)))";

            using (OracleConnection cn = new OracleConnection(strOracle))
            {
                Usuario dto = null;
                using (OracleCommand command = new OracleCommand(" select USER_ID from all_users Where USERNAME =  " + "'"+oUsuario.Nombre_Usuario+"'" , cn))
                {

                    command.CommandType = System.Data.CommandType.Text;

                    try {
                        cn.Open();
                        oUsuario.USER_ID = Convert.ToInt32(command.ExecuteScalar().ToString());
                    }
                    catch (Exception ex)
                    {
                        new Exception("Error en el metodo Listar" + ex.Message);
                    }

                }

                if(oUsuario.USER_ID != 0)
                {
                    Session["usuario"] = oUsuario;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewData["Mensaje"] = "Usuario no encontrado";
                    return View();
                }
            }
            {
           

               
        }

      

    }
}
}