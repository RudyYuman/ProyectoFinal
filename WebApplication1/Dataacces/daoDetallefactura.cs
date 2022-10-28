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
    public class daoDetallefactura : OracleConexion, Ioperaciones<DetalleFacturaBO>
    {
        public string Actualizar(DetalleFacturaBO dto)
        {
            string result = string.Empty;
            try
            {
                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    //cambiar el nombre del store procedure
                    using (OracleCommand command = new OracleCommand("SP_UPDATE_DETALLE_FACTURA", cn))
                    {
                        // cambiar por el nombre de los campos de la tabla que se esta trabajando
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new OracleParameter("P_ID_DETALLE_FACTURA", OracleType.VarChar)).Value = dto.ID_DETALLE_FACTURA;
                        command.Parameters.Add(new OracleParameter("P_CANTIDAD", OracleType.VarChar)).Value = dto.CANTIDAD;
                        command.Parameters.Add(new OracleParameter("P_PRECIO", OracleType.Double)).Value = Convert.ToDouble(dto.PRECIO);
                        command.Parameters.Add(new OracleParameter("P_TOTAL", OracleType.Double)).Value = Convert.ToDouble(dto.TOTAL);
                        command.Parameters.Add(new OracleParameter("P_DESCRIPCION", OracleType.VarChar)).Value = dto.DESCRIPCION;
                        command.Parameters.Add(new OracleParameter("P_NIT", OracleType.VarChar)).Value = dto.NIT;
                        command.Parameters.Add(new OracleParameter("P_FECHA", OracleType.DateTime)).Value = Convert.ToDateTime(dto.FECHA);
                        command.Parameters.Add(new OracleParameter("P_RESULT", OracleType.VarChar, 50)).Direction = System.Data.ParameterDirection.Output;
                        command.ExecuteNonQuery();
                        result = Convert.ToString(command.Parameters["P_RESULT"].Value);
                    }
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                new Exception("Error en el metodo Actualizar: " + ex.Message);
            }
            return result;
        }

        public string Eliminar(int dto)
        {
            string result = string.Empty;
            try
            {
                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    //cambiar el nombre del store procedure
                    using (OracleCommand command = new OracleCommand("SP_DELETE_DETALLE_FACTURA", cn))
                    {
                        // cambiar por el nombre de los campos de la tabla que se esta trabajando
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new OracleParameter("P_ID_DETALLE_FACTURA", OracleType.VarChar)).Value = dto;
                        command.Parameters.Add(new OracleParameter("P_RESULT", OracleType.VarChar, 50)).Direction = System.Data.ParameterDirection.Output;
                        command.ExecuteNonQuery();
                        result = Convert.ToString(command.Parameters["P_RESULT"].Value);
                    }
                    cn.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public string Insertar(DetalleFacturaBO dto)
        {
            string result = string.Empty;
            try
            {
                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    //cambiar el nombre del store procedure
                    using (OracleCommand command = new OracleCommand("SP_INSERT_DETALLE_FACTURA", cn))
                    {
                        // cambiar por el nombre de los campos de la tabla que se esta trabajando
                       
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new OracleParameter("P_ID_DETALLE_FACTURA", OracleType.VarChar)).Value = dto.ID_DETALLE_FACTURA;
                        command.Parameters.Add(new OracleParameter("P_CANTIDAD", OracleType.VarChar)).Value = dto.CANTIDAD;
                        command.Parameters.Add(new OracleParameter("P_PRECIO", OracleType.Double)).Value = Convert.ToDouble(dto.PRECIO);
                        command.Parameters.Add(new OracleParameter("P_TOTAL", OracleType.Double)).Value = Convert.ToDouble(dto.TOTAL);
                        command.Parameters.Add(new OracleParameter("P_DESCRIPCION", OracleType.VarChar)).Value = dto.DESCRIPCION;
                        command.Parameters.Add(new OracleParameter("P_NIT", OracleType.VarChar)).Value = dto.NIT;
                        command.Parameters.Add(new OracleParameter("P_FECHA", OracleType.DateTime)).Value = Convert.ToDateTime(dto.FECHA);
                        command.Parameters.Add(new OracleParameter("P_RESULT", OracleType.VarChar, 50)).Direction = System.Data.ParameterDirection.Output;
                        command.ExecuteNonQuery();
                        result = Convert.ToString(command.Parameters["P_RESULT"].Value);
                    }
                    cn.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public List<DetalleFacturaBO> Listar()
        {
            //Actualizamos el nombre de la tabla
            List<DetalleFacturaBO> list = new List<DetalleFacturaBO>();
            DetalleFacturaBO dto = null;
            try
            {

                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    //cambiar el nombre del store procedure
                    using (OracleCommand command = new OracleCommand("select * from DETALLE_FACTURA", cn))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        using (OracleDataReader dr = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {
                            while (dr.Read())
                            {
                                dto = new DetalleFacturaBO();
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
