using Dataacces;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_Layer
{
    public class NegTipoProducto
    {
        public List<TipoProductoBO> Listar()
        {
            daoTipoProducto dao = new daoTipoProducto();
            return dao.Listar();
        }

        public string Actualizar(TipoProductoBO dto)
        {
            daoTipoProducto dao = new daoTipoProducto();
            return dao.Actualizar(dto);
        }

        public string Eliminar(int dto)
        {
            daoTipoProducto dao = new daoTipoProducto();
            return dao.Eliminar(dto);
        }

        public string Insertar(TipoProductoBO dto)
        {
            daoTipoProducto dao = new daoTipoProducto();
            return dao.Insertar(dto);
        }
    }
}
