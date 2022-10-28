using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    public class EmpleadoBO
    {
        //FECHA_CONTRATACION DATE,
        //ID_ESTADO_EMPLEADO INTEGER,
        //ID_PUESTO_TRABAJADOR INTEGER,
        //FECHA_BAJA DATE,

        public int Id_EMPLEADO { get; set; }
        public string FECHA_CONTRATACION { get; set; }
        public int ID_ESTADO_EMPLEADO { get; set; }
        public int ID_PUESTO_TRABAJADOR { get; set; }
        public string FECHA_BAJA { get; set; }
    }
}
