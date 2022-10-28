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
    public class daoProveedor : OracleConexion, Ioperaciones<ProveedorBO>
    {
        public string Actualizar(ProveedorBO dto)
        {
            string result = string.Empty;
            try
            {
                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    //cambiar el nombre del store procedure
                    using (OracleCommand command = new OracleCommand("SP_UPDATE_PROVEEDOR", cn))
                    {
                        // cambiar por el nombre de los campos de la tabla que se esta trabajando
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new OracleParameter("P_ID_PROVEEDOR", OracleType.VarChar)).Value = dto.ID_PROVEEDOR;
                        command.Parameters.Add(new OracleParameter("P_DIRECCION", OracleType.VarChar)).Value = dto.DIRECCION;
                        command.Parameters.Add(new OracleParameter("P_ID_ESTADO_PRODUCTO", OracleType.VarChar)).Value = dto.ID_ESTADO_PRODUCTO;
                        command.Parameters.Add(new OracleParameter("P_ID_PUESTO_PROVEEDOR", OracleType.VarChar)).Value = dto.ID_PUESTO_PROVEEDOR;
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
                    using (OracleCommand command = new OracleCommand("SP_DELETE_PROVEEDOR", cn))
                    {
                        // cambiar por el nombre de los campos de la tabla que se esta trabajando
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new OracleParameter("P_ID_PROVEEDOR", OracleType.VarChar)).Value = dto;
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

        public string Insertar(ProveedorBO dto)
        {
            string result = string.Empty;
            try
            {
                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    //cambiar el nombre del store procedure
                    using (OracleCommand command = new OracleCommand("SP_INSERT_PROVEEDOR", cn))
                    {
                        // cambiar por el nombre de los campos de la tabla que se esta trabajando

                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new OracleParameter("P_ID_PROVEEDOR", OracleType.VarChar)).Value = dto.ID_PROVEEDOR;
                        command.Parameters.Add(new OracleParameter("P_DIRECCION", OracleType.VarChar)).Value = dto.DIRECCION;
                        command.Parameters.Add(new OracleParameter("P_ID_ESTADO_PRODUCTO", OracleType.VarChar)).Value = dto.ID_ESTADO_PRODUCTO;
                        command.Parameters.Add(new OracleParameter("P_ID_PUESTO_PROVEEDOR", OracleType.VarChar)).Value = dto.ID_PUESTO_PROVEEDOR;
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

        public List<ProveedorBO> Listar()
        {
            //Actualizamos el nombre de la tabla
            List<ProveedorBO> list = new List<ProveedorBO>();
            ProveedorBO dto = null;
            try
            {

                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    //cambiar el nombre del store procedure
                    using (OracleCommand command = new OracleCommand("select * from PROVEEDOR", cn))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        using (OracleDataReader dr = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {
                            while (dr.Read())
                            {
                                dto = new ProveedorBO();
                                dto.ID_PROVEEDOR = Convert.ToInt32(dr["ID_PROVEEDOR"]);
                                dto.DIRECCION = dr["DIRECCION"].ToString();
                                dto.ID_ESTADO_PRODUCTO = Convert.ToInt32(dr["ID_ESTADO_PRODUCTO"]);
                                dto.ID_PUESTO_PROVEEDOR = Convert.ToInt32(dr["ID_PUESTO_PROVEEDOR"]);
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
