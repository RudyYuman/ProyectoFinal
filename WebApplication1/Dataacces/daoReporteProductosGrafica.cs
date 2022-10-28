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
    public class daoReporteProductosGrafica : OracleConexion, Ioperaciones<ReporteProductosGraficaBO>
    {
        public string Actualizar(ReporteProductosGraficaBO dto)
        {
            throw new NotImplementedException();
        }

        public string Eliminar(int dto)
        {
            throw new NotImplementedException();
        }

        public string Insertar(ReporteProductosGraficaBO dto)
        {
            throw new NotImplementedException();
        }

        public List<ReporteProductosGraficaBO> Listar()
        {
            //Actualizamos el nombre de la tabla
            List<ReporteProductosGraficaBO> list = new List<ReporteProductosGraficaBO>();
            ReporteProductosGraficaBO dto = null;
            try
            {

                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    //cambiar el nombre del store procedure
                    using (OracleCommand command = new OracleCommand("select * from ventas_Grafica2", cn))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        using (OracleDataReader dr = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {
                            while (dr.Read())
                            {
                                dto = new ReporteProductosGraficaBO();
                                dto.name = dr["name"].ToString();
                                dto.y = Convert.ToDouble(dr["y"]);
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
            Console.Write(list);
        }
    }
}
