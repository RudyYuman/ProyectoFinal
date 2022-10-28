using Dataacces;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_Layer
{
    public class NegVentasNitGrafica
    {
        public List<VentasNitGraficaBO> Listar()
        {
            daoVentasNitGrafica dao = new daoVentasNitGrafica();
            return dao.Listar();
        }
    }
}
