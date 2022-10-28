using Dataacces;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_Layer
{
    public class NegDetalleVentasReport
    {
        public List<DetalleVentasReportBO> Listar()
        {
            daoDetalleVentasReport dao = new daoDetalleVentasReport();
            return dao.Listar();
        }
        
    }
}
