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
    public class daoTurnoEmpleado : OracleConexion, Ioperaciones<TurnoEmpleadoBO>
    {
        public string Actualizar(TurnoEmpleadoBO dto)
        {
            string result = string.Empty;
            try
            {
                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    //cambiar el nombre del store procedure
                    using (OracleCommand command = new OracleCommand("SP_UPDATE_TURNO_EMPLEADO", cn))
                    {
                        // cambiar por el nombre de los campos de la tabla que se esta trabajando
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new OracleParameter("P_Id_TURNO_EMPLEADO", OracleType.VarChar)).Value = dto.Id_TURNO_EMPLEADO;
                        command.Parameters.Add(new OracleParameter("P_TIPO_TURNO", OracleType.VarChar)).Value = dto.TIPO_TURNO;
                        command.Parameters.Add(new OracleParameter("P_FECHA_IN", OracleType.DateTime)).Value = Convert.ToDateTime(dto.FECHA_IN);
                        if (
                           dto.FECHA_FI == null
                          )
                        {
                            command.Parameters.Add(new OracleParameter("P_FECHA_FI", OracleType.DateTime)).Value = Convert.ToDateTime(dto.FECHA_IN); ;
                        }
                        else
                        {
                            command.Parameters.Add(new OracleParameter("P_FECHA_FI", OracleType.DateTime)).Value = Convert.ToDateTime(dto.FECHA_FI);
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
                    using (OracleCommand command = new OracleCommand("SP_DELETE_TURNO_EMPLEADO", cn))
                    {
                        // cambiar por el nombre de los campos de la tabla que se esta trabajando
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new OracleParameter("P_Id_TURNO_EMPLEADO", OracleType.VarChar)).Value = dto;
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

        public string Insertar(TurnoEmpleadoBO dto)
        {
            string result = string.Empty;
            try
            {
                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    //cambiar el nombre del store procedure
                    using (OracleCommand command = new OracleCommand("SP_INSERT_TURNO_EMPLEADO", cn))
                    {
                        // cambiar por el nombre de los campos de la tabla que se esta trabajando

                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new OracleParameter("P_Id_TURNO_EMPLEADO", OracleType.VarChar)).Value = dto.Id_TURNO_EMPLEADO;
                        command.Parameters.Add(new OracleParameter("P_TIPO_TURNO", OracleType.VarChar)).Value = dto.TIPO_TURNO;
                        command.Parameters.Add(new OracleParameter("P_FECHA_IN", OracleType.DateTime)).Value = Convert.ToDateTime(dto.FECHA_IN);
                        if (
                             dto.FECHA_FI == null
                            )
                        {
                            command.Parameters.Add(new OracleParameter("P_FECHA_FI", OracleType.DateTime)).Value = Convert.ToDateTime(dto.FECHA_IN); ;
                        }
                        else
                        {
                            command.Parameters.Add(new OracleParameter("P_FECHA_FI", OracleType.DateTime)).Value = Convert.ToDateTime(dto.FECHA_FI);
                        }
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

        public List<TurnoEmpleadoBO> Listar()
        {
            //Actualizamos el nombre de la tabla
            List<TurnoEmpleadoBO> list = new List<TurnoEmpleadoBO>();
            TurnoEmpleadoBO dto = null;
            try
            {

                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    //cambiar el nombre del store procedure
                    using (OracleCommand command = new OracleCommand("select * from TURNO_EMPLEADO", cn))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        using (OracleDataReader dr = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {
                            while (dr.Read())
                            {
                                dto = new TurnoEmpleadoBO();
                                dto.Id_TURNO_EMPLEADO = Convert.ToInt32(dr["Id_TURNO_EMPLEADO"]);
                                dto.TIPO_TURNO = dr["TIPO_TURNO"].ToString();
                                dto.FECHA_IN = dr["FECHA_IN"].ToString();
                                dto.FECHA_FI = dr["FECHA_FI"].ToString();
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
