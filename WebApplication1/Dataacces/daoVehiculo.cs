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
    public class daoVehiculo : OracleConexion, Ioperaciones<VehiculoBO>
    {
        public string Actualizar(VehiculoBO dto)
        {
            string result = string.Empty;
            try
            {
                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    //cambiar el nombre del store procedure
                    using (OracleCommand command = new OracleCommand("SP_UPDATE_VEHICULO", cn))
                    {
                        // cambiar por el nombre de los campos de la tabla que se esta trabajando
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new OracleParameter("P_ID_VEHICULO", OracleType.VarChar)).Value = dto.ID_VEHICULO;
                        command.Parameters.Add(new OracleParameter("P_NUMERO_MATRICULA", OracleType.VarChar)).Value = dto.NUMERO_MATRICULA;
                        command.Parameters.Add(new OracleParameter("P_ANIO", OracleType.VarChar)).Value = dto.ANIO;
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
                    using (OracleCommand command = new OracleCommand("SP_DELETE_VEHICULO", cn))
                    {
                        // cambiar por el nombre de los campos de la tabla que se esta trabajando
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new OracleParameter("P_ID_VEHICULO", OracleType.VarChar)).Value = dto;
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

        public string Insertar(VehiculoBO dto)
        {
            string result = string.Empty;
            try
            {
                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    //cambiar el nombre del store procedure
                    using (OracleCommand command = new OracleCommand("SP_INSERT_VEHICULO", cn))
                    {
                        // cambiar por el nombre de los campos de la tabla que se esta trabajando

                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new OracleParameter("P_ID_VEHICULO", OracleType.VarChar)).Value = dto.ID_VEHICULO;
                        command.Parameters.Add(new OracleParameter("P_NUMERO_MATRICULA", OracleType.VarChar)).Value = dto.NUMERO_MATRICULA;
                        command.Parameters.Add(new OracleParameter("P_ANIO", OracleType.VarChar)).Value = dto.ANIO;
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

        public List<VehiculoBO> Listar()
        {
            //Actualizamos el nombre de la tabla
            List<VehiculoBO> list = new List<VehiculoBO>();
            VehiculoBO dto = null;
            try
            {

                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    //cambiar el nombre del store procedure
                    using (OracleCommand command = new OracleCommand("select * from VEHICULO", cn))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        using (OracleDataReader dr = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {
                            while (dr.Read())
                            {
                                dto = new VehiculoBO();
                                dto.ID_VEHICULO = Convert.ToInt32(dr["ID_VEHICULO"]);
                                dto.NUMERO_MATRICULA = dr["NUMERO_MATRICULA"].ToString();
                                dto.ANIO = Convert.ToInt32(dr["ANIO"]);
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
