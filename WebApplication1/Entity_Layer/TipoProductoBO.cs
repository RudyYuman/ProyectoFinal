using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    public class TipoProductoBO
    {
    //ID_TIPO_PRODUCTO INTEGER,
    //TIPO_PRODUCTO VARCHAR2(30 BYTE),
    //TIPO_MEDIDA VARCHAR2(30 BYTE),
        public int ID_TIPO_PRODUCTO { get; set; }
        public string TIPO_PRODUCTO { get; set; }
        public string TIPO_MEDIDA { get; set; }

    }
}
