using Dataacces;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_Layer
{
    public class NegDetalleFactura
    {
        public List<DetalleFacturaBO> Listar()
        {
            daoDetallefactura dao = new daoDetallefactura();
            return dao.Listar();
        }

        public string Actualizar(DetalleFacturaBO dto)
        {
            daoDetallefactura dao = new daoDetallefactura();
            return dao.Actualizar(dto);
        }

        public string Eliminar(int dto)
        {
            daoDetallefactura dao = new daoDetallefactura();
            return dao.Eliminar(dto);
        }

        public string Insertar(DetalleFacturaBO dto)
        {
            daoDetallefactura dao = new daoDetallefactura();
            return dao.Insertar(dto);
        }
    }
}
