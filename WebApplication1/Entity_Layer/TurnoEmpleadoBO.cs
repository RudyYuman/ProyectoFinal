using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    public class TurnoEmpleadoBO
    {
        //Id_TURNO_EMPLEADO INTEGER,
        //TIPO_TURNO VARCHAR2(10 BYTE)

        public int Id_TURNO_EMPLEADO { get; set; }
        public string TIPO_TURNO { get; set; }
        public string FECHA_IN { get; set; }
        public string FECHA_FI { get; set; }
    }
}
