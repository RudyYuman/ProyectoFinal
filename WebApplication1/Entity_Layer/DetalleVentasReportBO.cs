using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    public class DetalleVentasReportBO
    {
        //ID_DETALLE_FACTURA INTEGER,
        //CANTIDAD NUMBER(10,0),
        //PRECIO NUMBER(6,2),
        //TOTAL NUMBER(6,2),
        //DESCRIPCION VARCHAR2(100 BYTE),
        //NIT VARCHAR2(10 BYTE),
        //FECHA DATE,
        public int ID_DETALLE_FACTURA { get; set; }
        public int CANTIDAD { get; set; }
        public double PRECIO { get; set; }
        public double TOTAL { get; set; }
        public string DESCRIPCION { get; set; }
        public string NIT { get; set; }
        public string FECHA { get; set; }
    }
}
