using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    //Cambiar a public la clase
    public class ClienteBO
    {

        // copiara los campos de la tabla para colocar los mismos con el mismo nombre

    //Id_CLIENTE INTEGER,
    //FECHA_NACIMIENTO DATE,
    //Id_ESTADO_CLIENTE INTEGER,

        // agregar los metodos de getter and Setter
        // revisar los tipos de dato
        public int Id_CLIENTE { get; set; }
        public string FECHA_NACIMIENTO { get; set; }
        public int Id_ESTADO_CLIENTE { get; set; }

    }
}
