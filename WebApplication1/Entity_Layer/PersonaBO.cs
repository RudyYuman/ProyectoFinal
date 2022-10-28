using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    public class PersonaBO
    {
        //Copio los campos de la tabla para generar los getter and setter

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

        //agrego los Getter and Setter

        public int Id_persona { get; set; }
        public int No_Doc_Id { get; set; }
        public string NOMBRE1 { get; set; }
        public string NOMBRE2 { get; set; }
        public string OTRO_NOMBRE { get; set; }
        public string APELLIDO1 { get; set; }
        public string APELLIDO2 { get; set; }
        public string APELLIDO_CASADA { get; set; }
        public int TELEFONO { get; set; }
        public String FECHA_NACIMIENTO { get; set; }


    }
}
