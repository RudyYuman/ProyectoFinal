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

    public class daoSedeServicio : OracleConexion, Ioperaciones<SedeServicioBO>
    {
        public string Actualizar(SedeServicioBO dto)
        {
            string result = string.Empty;
            try
            {
                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    using (OracleCommand command = new OracleCommand("SP_UPDATE_SEDE_SERVICIO", cn))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new OracleParameter("P_ID_SEDE_SERVICIO", OracleType.VarChar)).Value = dto.ID_SEDE_SERVICIO;
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
                    using (OracleCommand command = new OracleCommand("SP_DELETE_SEDE_SERVICIO", cn))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new OracleParameter("P_ID_SEDE_SERVICIO", OracleType.VarChar)).Value = dto;
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

        public string Insertar(SedeServicioBO dto)
        {
            string result = string.Empty;
            try
            {
                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    using (OracleCommand command = new OracleCommand("SP_INSERT_SEDE_SERVICIO", cn))
                    {
                        //ID_SEDE_SERVICIO INTEGER,
                        //NOMBRE_SERVICIO VARCHAR2(30 BYTE),

                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new OracleParameter("P_ID_SEDE_SERVICIO", OracleType.VarChar)).Value = dto.ID_SEDE_SERVICIO;
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

        public List<SedeServicioBO> Listar()
        {
            List<SedeServicioBO> list = new List<SedeServicioBO>();
            SedeServicioBO dto = null;
            try
            {

                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    using (OracleCommand command = new OracleCommand("select * from SEDE_SERVICIO", cn))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        using (OracleDataReader dr = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {
                            while (dr.Read())
                            {
                                //ID_SEDE_SERVICIO INTEGER,
                                //NOMBRE_SERVICIO VARCHAR2(30 BYTE),

                                dto = new SedeServicioBO();
                                dto.ID_SEDE_SERVICIO = Convert.ToInt32(dr["ID_SEDE_SERVICIO"]);
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
