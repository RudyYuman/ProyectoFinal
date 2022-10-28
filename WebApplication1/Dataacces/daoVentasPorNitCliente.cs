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
    public class daoVentasPorNitCliente : OracleConexion, Ioperaciones<VentasPorNitClienteBO>
    {
        public string Actualizar(VentasPorNitClienteBO dto)
        {
            throw new NotImplementedException();
        }

        public string Eliminar(int dto)
        {
            throw new NotImplementedException();
        }

        public string Insertar(VentasPorNitClienteBO dto)
        {
            throw new NotImplementedException();
        }

        public List<VentasPorNitClienteBO> Listar()
        {
            List<VentasPorNitClienteBO> list = new List<VentasPorNitClienteBO>();
            VentasPorNitClienteBO dto = null;
            try
            {

                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    //cambiar el nombre del store procedure
                    using (OracleCommand command = new OracleCommand("select * from VentaPorNitCliente", cn))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        using (OracleDataReader dr = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {
                            while (dr.Read())
                            {
                                dto = new VentasPorNitClienteBO();
                                dto.NIT = dr["NIT"].ToString();
                                dto.TOTAL = Convert.ToDouble(dr["TOTAL"].ToString());
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
