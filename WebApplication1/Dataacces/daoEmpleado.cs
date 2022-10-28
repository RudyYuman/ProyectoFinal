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
    public class daoEmpleado : OracleConexion, Ioperaciones<EmpleadoBO>
    {
        public string Actualizar(EmpleadoBO dto)
        {
            string result = string.Empty;
            try
            {
                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    //cambiar el nombre del store procedure
                    using (OracleCommand command = new OracleCommand("SP_UPDATE_EMPLEADO", cn))
                    {
                        // cambiar por el nombre de los campos de la tabla que se esta trabajando
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new OracleParameter("P_Id_EMPLEADO", OracleType.VarChar)).Value = dto.Id_EMPLEADO;
                        command.Parameters.Add(new OracleParameter("P_FECHA_CONTRATACION", OracleType.DateTime)).Value = Convert.ToDateTime(dto.FECHA_CONTRATACION);
                        command.Parameters.Add(new OracleParameter("P_ID_ESTADO_EMPLEADO", OracleType.VarChar)).Value = dto.ID_ESTADO_EMPLEADO;
                        command.Parameters.Add(new OracleParameter("P_ID_PUESTO_TRABAJADOR", OracleType.VarChar)).Value = dto.ID_PUESTO_TRABAJADOR;
                        if (
                            dto.FECHA_BAJA == null
                           )
                        {
                            command.Parameters.Add(new OracleParameter("P_FECHA_BAJA", OracleType.DateTime)).Value = Convert.ToDateTime(dto.FECHA_CONTRATACION); ;
                        }
                        else
                        {
                            command.Parameters.Add(new OracleParameter("P_FECHA_BAJA", OracleType.DateTime)).Value = Convert.ToDateTime(dto.FECHA_BAJA);
                        }
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
                    using (OracleCommand command = new OracleCommand("SP_DELETE_EMPLEADO", cn))
                    {
                        // cambiar por el nombre de los campos de la tabla que se esta trabajando
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new OracleParameter("P_Id_EMPLEADO", OracleType.VarChar)).Value = dto;
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

        public string Insertar(EmpleadoBO dto)
        {
            string result = string.Empty;
            try
            {
                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    //cambiar el nombre del store procedure
                    using (OracleCommand command = new OracleCommand("SP_INSERT_EMPLEADO", cn))
                    {
                        // cambiar por el nombre de los campos de la tabla que se esta trabajando

                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new OracleParameter("P_Id_EMPLEADO", OracleType.VarChar)).Value = dto.Id_EMPLEADO;
                        command.Parameters.Add(new OracleParameter("P_FECHA_CONTRATACION", OracleType.DateTime)).Value = Convert.ToDateTime(dto.FECHA_CONTRATACION);
                        command.Parameters.Add(new OracleParameter("P_ID_ESTADO_EMPLEADO", OracleType.VarChar)).Value = dto.ID_ESTADO_EMPLEADO;
                        command.Parameters.Add(new OracleParameter("P_ID_PUESTO_TRABAJADOR", OracleType.VarChar)).Value = dto.ID_PUESTO_TRABAJADOR;
                        command.Parameters.Add(new OracleParameter("P_FECHA_BAJA", OracleType.DateTime)).Value = Convert.ToDateTime(dto.FECHA_BAJA);
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

        public List<EmpleadoBO> Listar()
        {
            //Actualizamos el nombre de la tabla
            List<EmpleadoBO> list = new List<EmpleadoBO>();
            EmpleadoBO dto = null;
            try
            {

                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    //cambiar el nombre del store procedure
                    using (OracleCommand command = new OracleCommand("select * from EMPLEADO", cn))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        using (OracleDataReader dr = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {
                            while (dr.Read())
                            {
                                dto = new EmpleadoBO();
                                dto.Id_EMPLEADO = Convert.ToInt32(dr["Id_EMPLEADO"]);
                                dto.FECHA_CONTRATACION = dr["FECHA_CONTRATACION"].ToString();
                                dto.ID_ESTADO_EMPLEADO = Convert.ToInt32(dr["ID_ESTADO_EMPLEADO"].ToString());
                                dto.ID_PUESTO_TRABAJADOR = Convert.ToInt32(dr["ID_PUESTO_TRABAJADOR"].ToString());
                                dto.FECHA_BAJA = dr["FECHA_BAJA"].ToString();
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
