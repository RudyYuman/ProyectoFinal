using Dataacces.Contract;
using Dataacces.Repository;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataacces
{
    public class daoVentasProducto : OracleConexion, Ioperaciones<VentasProductoBO>
    {
        public string Actualizar(VentasProductoBO dto)
        {
            throw new NotImplementedException();
        }

        public string Eliminar(int dto)
        {
            throw new NotImplementedException();
        }

        public string Insertar(VentasProductoBO dto)
        {
            throw new NotImplementedException();
        }

        public List<VentasProductoBO> Listar()
        {
            //Actualizamos el nombre de la tabla
            List<VentasProductoBO> list = new List<VentasProductoBO>();
            VentasProductoBO dto = null;
            try
            {

                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    //cambiar el nombre del store procedure
                    using (OracleCommand command = new OracleCommand("select * from VentaProductos", cn))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        using (OracleDataReader dr = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {
                            while (dr.Read())
                            {
                                dto = new VentasProductoBO();
                                dto.CANTIDAD = Convert.ToInt32(dr["CANTIDAD"]);
                                dto.DESCRIPCION = dr["DESCRIPCION"].ToString();
                                dto.TOTAL = Convert.ToDouble(dr["TOTAL"]);
                                list.Add(dto);
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                new Exception("Error en el metodo Listar" + ex.Message);
            }

            return list;
        }
    }
}
