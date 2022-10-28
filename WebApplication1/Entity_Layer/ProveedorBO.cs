using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    public class ProveedorBO
    {
        //ID_PROVEEDOR INTEGER,
        //DIRECCION VARCHAR2(30 BYTE),
        //ID_ESTADO_PRODUCTO INTEGER,
        //ID_PUESTO_PROVEEDOR INTEGER,

        public int ID_PROVEEDOR { get; set; }
        public string DIRECCION { get; set; }
        public int ID_ESTADO_PRODUCTO { get; set; }
        public int ID_PUESTO_PROVEEDOR { get; set; }
    }
}
