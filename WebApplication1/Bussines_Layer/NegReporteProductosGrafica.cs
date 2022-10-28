using Dataacces;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_Layer
{
    public class NegReporteProductosGrafica
    {
        public List<ReporteProductosGraficaBO> Listar()
        {
            daoReporteProductosGrafica dao = new daoReporteProductosGrafica();
            return dao.Listar();
        }
    }
}
