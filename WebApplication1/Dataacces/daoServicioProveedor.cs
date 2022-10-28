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
    public class daoServicioProveedor : OracleConexion, Ioperaciones<ServicioProveedorBO>
    {
        public string Actualizar(ServicioProveedorBO dto)
        {
            string result = string.Empty;
            try
            {
                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    //cambiar el nombre del store procedure
                    using (OracleCommand command = new OracleCommand("SP_UPDATE_SERVICIO_PROVEEDOR", cn))
                    {
                        // cambiar por el nombre de los campos de la tabla que se esta trabajando
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new OracleParameter("P_ID_PRODUCTO_PROVEEDOR", OracleType.VarChar)).Value = dto.ID_PRODUCTO_PROVEEDOR;
                        command.Parameters.Add(new OracleParameter("P_NOMBRE_PRODUCTO", OracleType.VarChar)).Value = dto.NOMBRE_PRODUCTO;
                        command.Parameters.Add(new OracleParameter("P_NOMBRE_SERVICIO", OracleType.VarChar)).Value = dto.NOMBRE_SERVICIO;
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
                    using (OracleCommand command = new OracleCommand("SP_DELETE_SERVICIO_PROVEEDOR", cn))
                    {
                        // cambiar por el nombre de los campos de la tabla que se esta trabajando
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new OracleParameter("P_ID_PRODUCTO_PROVEEDOR", OracleType.VarChar)).Value = dto;
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

        public string Insertar(ServicioProveedorBO dto)
        {
            string result = string.Empty;
            try
            {
                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    //cambiar el nombre del store procedure
                    using (OracleCommand command = new OracleCommand("SP_INSERT_SERVICIO_PROVEEDOR", cn))
                    {
                        // cambiar por el nombre de los campos de la tabla que se esta trabajando

                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new OracleParameter("P_ID_PRODUCTO_PROVEEDOR", OracleType.VarChar)).Value = dto.ID_PRODUCTO_PROVEEDOR;
                        command.Parameters.Add(new OracleParameter("P_NOMBRE_PRODUCTO", OracleType.VarChar)).Value = dto.NOMBRE_PRODUCTO;
                        command.Parameters.Add(new OracleParameter("P_NOMBRE_SERVICIO", OracleType.VarChar)).Value = dto.NOMBRE_SERVICIO;
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

        public List<ServicioProveedorBO> Listar()
        {
            //Actualizamos el nombre de la tabla
            List<ServicioProveedorBO> list = new List<ServicioProveedorBO>();
            ServicioProveedorBO dto = null;
            try
            {

                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    //cambiar el nombre del store procedure
                    using (OracleCommand command = new OracleCommand("select * from SERVICIO_PROVEEDOR", cn))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        using (OracleDataReader dr = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {
                            while (dr.Read())
                            {
                                dto = new ServicioProveedorBO();
                                dto.ID_PRODUCTO_PROVEEDOR = Convert.ToInt32(dr["ID_PRODUCTO_PROVEEDOR"]);
                                dto.NOMBRE_PRODUCTO = dr["NOMBRE_PRODUCTO"].ToString();
                                dto.NOMBRE_SERVICIO = dr["NOMBRE_SERVICIO"].ToString();
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
