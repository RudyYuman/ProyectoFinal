using Dataacces.Repository;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Inicio : System.Web.UI.MasterPage
    {

        private Conn conexion = new Conn("", "");
        protected void Page_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public void MsgBox(String ex, Page pg, Object obj)
        {
            string s = "<SCRIPT language='javascript'>alert('" + ex.Replace("\r\n", "\\n").Replace("'", "") + "'); </SCRIPT>";
            Type cstype = obj.GetType();
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }
    

        public List<ClienteBO> Listar()
        {
            //Actualizamos el nombre de la tabla
            List<ClienteBO> list = new List<ClienteBO>();
            ClienteBO dto = null;
            try
            {

                using (OracleConnection cn = new OracleConnection(conexion.strOracle))
                {
                    cn.Open();
                    //cambiar el nombre del store procedure
                    using (OracleCommand command = new OracleCommand("select * from cliente", cn))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        using (OracleDataReader dr = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {
                            while (dr.Read())
                            {

                            }
                        }
                    }
                }
                MsgBox("Conexion realizada", this.Page, this);

            }
            catch (Exception ex)
            {
                new Exception("Error en el metodo Listar" + ex.Message);
                MsgBox("Conexion realizada", this.Page, this);
            }

            return list;
        }

    }
}