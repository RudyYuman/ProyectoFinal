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
    public class daoDetalleVentasReport : OracleConexion, Ioperaciones<DetalleVentasReportBO>
    {
        public string Actualizar(DetalleVentasReportBO dto)
        {
            throw new NotImplementedException();
        }

        public string Eliminar(int dto)
        {
            throw new NotImplementedException();
        }

        public string Insertar(DetalleVentasReportBO dto)
        {
            throw new NotImplementedException();
        }

        public List<DetalleVentasReportBO> Listar()
        {
            //Actualizamos el nombre de la tabla
            List<DetalleVentasReportBO> list = new List<DetalleVentasReportBO>();
            DetalleVentasReportBO dto = null;
            try
            {

                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    //cambiar el nombre del store procedure
                    using (OracleCommand command = new OracleCommand("select * from VENTAS", cn))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        using (OracleDataReader dr = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {
                            while (dr.Read())
                            {
                                dto = new DetalleVentasReportBO();
                                dto.ID_DETALLE_FACTURA = Convert.ToInt32(dr["ID_DETALLE_FACTURA"]);
                                dto.CANTIDAD = Convert.ToInt32(dr["CANTIDAD"]);
                                dto.PRECIO = Convert.ToDouble(dr["PRECIO"]);
                                dto.TOTAL = Convert.ToDouble(dr["TOTAL"]);
                                dto.DESCRIPCION = dr["DESCRIPCION"].ToString();
                                dto.NIT = dr["NIT"].ToString();
                                dto.FECHA = dr["FECHA"].ToString();
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
