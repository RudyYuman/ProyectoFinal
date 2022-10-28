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
    //hero la conexion de oracle, y la interfaz ioperaciones<coloco la tabla me dara error doy ctrl + . y luego enter para generar las funcioens>
    public class daoPersona : OracleConexion, Ioperaciones<PersonaBO>
    {
        public string Actualizar(PersonaBO dto)
        {
            string result = string.Empty;
            try
            {
                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    using (OracleCommand command = new OracleCommand("SP_UPDATE_PERSONA", cn))
                    {

                        //   Id_persona INTEGER,
                        //   No_Doc_Id NUMBER(30,0), 
                        //   NOMBRE1 VARCHAR2(30 BYTE),
                        //   NOMBRE2 VARCHAR2(30 BYTE),
                        //   OTRO_NOMBRE VARCHAR2(30 BYTE),
                        //   APELLIDO1 VARCHAR2(30 BYTE),
                        //   APELLIDO2 VARCHAR2(30 BYTE),
                        //   APELLIDO_CASADA VARCHAR2(30 BYTE),
                        //   TELEFONO NUMBER(8,0),
                        //   FECHA_NACIMIENTO DATE,

                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new OracleParameter("P_Id_persona", OracleType.VarChar)).Value = dto.Id_persona;
                        command.Parameters.Add(new OracleParameter("P_No_Doc_Id", OracleType.VarChar)).Value = dto.No_Doc_Id;
                        command.Parameters.Add(new OracleParameter("P_NOMBRE1", OracleType.VarChar)).Value = dto.NOMBRE1;
                        command.Parameters.Add(new OracleParameter("P_NOMBRE2", OracleType.VarChar)).Value = dto.NOMBRE2;
                        if (
                            command.Parameters.Add(new OracleParameter("P_OTRO_NOMBRE", OracleType.VarChar)).Value == ""
                            ) 
                        {
                            command.Parameters.Add(new OracleParameter("P_OTRO_NOMBRE", OracleType.VarChar)).Value = " ";
                        }
                        else {
                            command.Parameters.Add(new OracleParameter("P_OTRO_NOMBRE", OracleType.VarChar)).Value = dto.OTRO_NOMBRE;
                        }
                        
                        command.Parameters.Add(new OracleParameter("P_APELLIDO1", OracleType.VarChar)).Value = dto.APELLIDO1;
                        command.Parameters.Add(new OracleParameter("P_APELLIDO2", OracleType.VarChar)).Value = dto.APELLIDO2;
                        command.Parameters.Add(new OracleParameter("P_APELLIDO_CASADA", OracleType.VarChar)).Value = dto.APELLIDO_CASADA;
                        command.Parameters.Add(new OracleParameter("P_TELEFONO", OracleType.VarChar)).Value = dto.TELEFONO;
                        command.Parameters.Add(new OracleParameter("P_FECHA_NACIMIENTO", OracleType.DateTime)).Value = Convert.ToDateTime(dto.FECHA_NACIMIENTO);
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
                    using (OracleCommand command = new OracleCommand("SP_DELETE_PERSONA", cn))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new OracleParameter("P_Id_persona", OracleType.VarChar)).Value = dto;
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

        public string Insertar(PersonaBO dto)
        {
            string result = string.Empty;
            try
            {
                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    cn.Open();
                    using (OracleCommand command = new OracleCommand("SP_INSERT_PERSONA", cn))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new OracleParameter("P_Id_persona", OracleType.VarChar)).Value = dto.Id_persona;
                        command.Parameters.Add(new OracleParameter("P_No_Doc_Id", OracleType.VarChar)).Value = dto.No_Doc_Id;
                        command.Parameters.Add(new OracleParameter("P_NOMBRE1", OracleType.VarChar)).Value = dto.NOMBRE1;
                        command.Parameters.Add(new OracleParameter("P_NOMBRE2", OracleType.VarChar)).Value = dto.NOMBRE2;
                        if (
                            dto.OTRO_NOMBRE == null
                           )
                        {
                            command.Parameters.Add(new OracleParameter("P_OTRO_NOMBRE", OracleType.VarChar)).Value = "N/A";
                        }
                        else
                        {
                            command.Parameters.Add(new OracleParameter("P_OTRO_NOMBRE", OracleType.VarChar)).Value = dto.OTRO_NOMBRE;
                        }
                        command.Parameters.Add(new OracleParameter("P_APELLIDO1", OracleType.VarChar)).Value = dto.APELLIDO1;
                        command.Parameters.Add(new OracleParameter("P_APELLIDO2", OracleType.VarChar)).Value = dto.APELLIDO2;
                        if (
                            dto.APELLIDO_CASADA == null
                           )
                        {
                            command.Parameters.Add(new OracleParameter("P_APELLIDO_CASADA", OracleType.VarChar)).Value = "N/A";
                        }
                        else
                        {
                            command.Parameters.Add(new OracleParameter("P_APELLIDO_CASADA", OracleType.VarChar)).Value = dto.APELLIDO_CASADA;
                        }
                        if (
                            dto.TELEFONO.ToString().Length < 8
                           )
                        {
                            command.Parameters.Add(new OracleParameter("P_TELEFONO", OracleType.VarChar)).Value = 0;
                        }
                        else
                        {
                            command.Parameters.Add(new OracleParameter("P_TELEFONO", OracleType.VarChar)).Value = dto.TELEFONO;
                        }
                        command.Parameters.Add(new OracleParameter("P_FECHA_NACIMIENTO", OracleType.DateTime)).Value = Convert.ToDateTime(dto.FECHA_NACIMIENTO);
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

        public List<PersonaBO> Listar()
        {
            //creo una lista usando la calse personaBO
            List <PersonaBO> list = new List<PersonaBO>();
            //creo una variable tipo personaBO 
            PersonaBO dto = null;
            try
            {
                //llamo la conexion
                using (OracleConnection cn = new OracleConnection(strOracle))
                {
                    //abro la conexion
                    cn.Open();
                    //uso oracle command para mandar la instruccion SQL
                    using (OracleCommand command = new OracleCommand("select * from persona", cn))
                    {
                        //Ejecuto la instruccion
                        command.CommandType = System.Data.CommandType.Text;
                        using (OracleDataReader dr = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {
                            //leo cada una de las filas
                            try { 
                            while (dr.Read())
                            {
                                // uso los datos de la tabla para poder colocar los nombres de los campos 

                                //   Id_persona INTEGER,
                                //   No_Doc_Id NUMBER(30,0), 
                                //   NOMBRE1 VARCHAR2(30 BYTE),
                                //   NOMBRE2 VARCHAR2(30 BYTE),
                                //   OTRO_NOMBRE VARCHAR2(30 BYTE),
                                //   APELLIDO1 VARCHAR2(30 BYTE),
                                //   APELLIDO2 VARCHAR2(30 BYTE),
                                //   APELLIDO_CASADA VARCHAR2(30 BYTE),
                                //   TELEFONO NUMBER(8,0),
                                //   FECHA_NACIMIENTO DATE,

                                //agrego cada uno de los campos a la lista
                                dto = new PersonaBO();
                                dto.Id_persona = Convert.ToInt32(dr["Id_persona"]);
                                dto.No_Doc_Id = Convert.ToInt32(dr["No_Doc_Id"]);
                                dto.NOMBRE1 = dr["NOMBRE1"].ToString();
                                dto.NOMBRE2 = dr["NOMBRE2"].ToString();
                                dto.OTRO_NOMBRE = dr["OTRO_NOMBRE"].ToString();
                                dto.APELLIDO1 = dr["APELLIDO1"].ToString();
                                dto.APELLIDO2 = dr["APELLIDO2"].ToString();
                                dto.APELLIDO_CASADA = dr["APELLIDO_CASADA"].ToString();
                                dto.TELEFONO = Convert.ToInt32(dr["TELEFONO"]);
                                dto.FECHA_NACIMIENTO = dr["FECHA_NACIMIENTO"].ToString();
                                list.Add(dto);
                            }
                        }
                            catch (Exception ex)
                            {
                                new Exception("Error en el metodo Listar" + ex.Message);
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
