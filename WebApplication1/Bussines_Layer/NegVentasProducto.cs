using Dataacces;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_Layer
{
    public class NegVentasProducto
    {
        public List<VentasProductoBO> Listar()
        {
            daoVentasProducto dao = new daoVentasProducto();
            return dao.Listar();
        }
    }
}
