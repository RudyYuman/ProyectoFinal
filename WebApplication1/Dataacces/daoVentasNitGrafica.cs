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
    public class daoVentasNitGrafica : OracleConexion, Ioperaciones<VentasNitGraficaBO>
    {
        public string Actualizar(VentasNitGraficaBO dto)
        {
            throw new NotImplementedException();
        }

        public string Eliminar(int dto)
        {
            throw new NotImplementedException();
        }

        public string Insertar(VentasNitGraficaBO dto)
        {
            throw new NotImplementedException();
        }

        public List<VentasNitGraficaBO> Listar()
        {
            List<VentasNitGraficaBO> list = new List<VentasNitGraficaBO>();
            VentasNitGraficaBO dto = null;
            try
            {

                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    //cambiar el nombre del store procedure
                    using (OracleCommand command = new OracleCommand("select * from ventas_Grafica3", cn))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        using (OracleDataReader dr = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {
                            while (dr.Read())
                            {
                                dto = new VentasNitGraficaBO();
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
