using Dataacces;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_Layer
{
    public class NegVentasPorNitCliente
    {
        public List<VentasPorNitClienteBO> Listar()
        {
            daoVentasPorNitCliente dao = new daoVentasPorNitCliente();
            return dao.Listar();
        }
    }
}
