using Dataacces;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_Layer
{
    public class NegFactura
    {
        public List<FacturaBO> Listar()
        {
            daoFactura dao = new daoFactura();
            return dao.Listar();
        }

        public string Actualizar(FacturaBO dto)
        {
            daoFactura dao = new daoFactura();
            return dao.Actualizar(dto);
        }

        public string Eliminar(int dto)
        {
            daoFactura dao = new daoFactura();
            return dao.Eliminar(dto);
        }

        public string Insertar(FacturaBO dto)
        {
            daoFactura dao = new daoFactura();
            return dao.Insertar(dto);
        }
    }
}
