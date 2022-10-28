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
    public class daoTurno : OracleConexion, Ioperaciones<TurnoBO>
    {
        public string Actualizar(TurnoBO dto)
        {
            string result = string.Empty;
            try
            {
                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    //cambiar el nombre del store procedure
                    using (OracleCommand command = new OracleCommand("SP_UPDATE_TURNO", cn))
                    {
                        // cambiar por el nombre de los campos de la tabla que se esta trabajando
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new OracleParameter("P_Id_TURNO", OracleType.VarChar)).Value = dto.Id_TURNO;
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
                    using (OracleCommand command = new OracleCommand("SP_DELETE_TURNO", cn))
                    {
                        // cambiar por el nombre de los campos de la tabla que se esta trabajando
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new OracleParameter("P_Id_TURNO", OracleType.VarChar)).Value = dto;
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

        public string Insertar(TurnoBO dto)
        {
            string result = string.Empty;
            try
            {
                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    //cambiar el nombre del store procedure
                    using (OracleCommand command = new OracleCommand("SP_INSERT_TURNO", cn))
                    {
                        // cambiar por el nombre de los campos de la tabla que se esta trabajando

                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new OracleParameter("P_Id_TURNO", OracleType.VarChar)).Value = dto.Id_TURNO;
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

        public List<TurnoBO> Listar()
        {
            //Actualizamos el nombre de la tabla
            List<TurnoBO> list = new List<TurnoBO>();
            TurnoBO dto = null;
            try
            {

                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    //cambiar el nombre del store procedure
                    using (OracleCommand command = new OracleCommand("select * from TURNO", cn))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        using (OracleDataReader dr = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {
                            while (dr.Read())
                            {
                                dto = new TurnoBO();
                                dto.Id_TURNO = Convert.ToInt32(dr["Id_TURNO"]);
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
