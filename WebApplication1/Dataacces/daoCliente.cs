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
    //ponemos la clase como publica
    //Heredamos : OracleConexion, Ioperaciones<ClienteBO>, nos dara error damos ctrl + . y luego
    //seleccionamo la opcion de implementar interface (implement interface) y luego enter para crear los metodos
    //Eliminar, actualizar, insertar y listar
    public class daoCliente: OracleConexion, Ioperaciones<ClienteBO>
    {
        public string Actualizar(ClienteBO dto)
        {
            string result = string.Empty;
            try
            {
                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    //cambiar el nombre del store procedure
                    using (OracleCommand command = new OracleCommand("SP_UPDATE_CLIENTE", cn))
                    {
                        // cambiar por el nombre de los campos de la tabla que se esta trabajando
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new OracleParameter("P_CLIENTE_ID", OracleType.VarChar)).Value = dto.Id_CLIENTE;
                        command.Parameters.Add(new OracleParameter("P_FECHA_NACIMIENTO", OracleType.DateTime)).Value = dto.FECHA_NACIMIENTO;
                        command.Parameters.Add(new OracleParameter("P_Id_ESTADO_CLIENTE", OracleType.VarChar)).Value = dto.Id_ESTADO_CLIENTE;
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
                    using (OracleCommand command = new OracleCommand("SP_DELETE_CLIENTE", cn))
                    {
                        // cambiar por el nombre de los campos de la tabla que se esta trabajando
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new OracleParameter("P_CLIENTE_ID", OracleType.VarChar)).Value = dto;
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

        public string Insertar(ClienteBO dto)
        {
            string result = string.Empty;
            try
            {
                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    //cambiar el nombre del store procedure
                    using (OracleCommand command = new OracleCommand("SP_INSERT_CLIENTE", cn))
                    {
                        // cambiar por el nombre de los campos de la tabla que se esta trabajando

                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new OracleParameter("P_CLIENTE_ID", OracleType.VarChar)).Value = dto.Id_CLIENTE;
                        command.Parameters.Add(new OracleParameter("P_FECHA_NACIMIENTO", OracleType.DateTime)).Value = dto.FECHA_NACIMIENTO;
                        command.Parameters.Add(new OracleParameter("P_Id_ESTADO_CLIENTE", OracleType.VarChar)).Value = dto.Id_ESTADO_CLIENTE;
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

        public List<ClienteBO> Listar()
        {
            //Actualizamos el nombre de la tabla
            List <ClienteBO> list = new List<ClienteBO>();
            ClienteBO dto = null;
            try 
            {

                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    //cambiar el nombre del store procedure
                    using (OracleCommand command = new OracleCommand("select * from cliente",cn))
                    {
                        command.CommandType =  System.Data.CommandType.Text;
                        using (OracleDataReader dr = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {
                            while (dr.Read()) 
                            { 
                                dto  = new  ClienteBO();
                                dto.Id_CLIENTE = Convert.ToInt32(dr["Id_CLIENTE"]);
                                dto.FECHA_NACIMIENTO = dr["FECHA_NACIMIENTO"].ToString();
                                dto.Id_ESTADO_CLIENTE = Convert.ToInt32(dr["Id_ESTADO_CLIENTE"]);
                                list.Add(dto);
                            }
                        }
                    }
                }

            }
            catch(Exception ex)
            {
                new Exception("Error en el metodo Listar" + ex.Message);
            }

            return list;
        }
    }
}
