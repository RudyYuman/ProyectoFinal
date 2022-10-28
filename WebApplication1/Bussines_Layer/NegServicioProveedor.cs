using Dataacces;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_Layer
{
    public class NegServicioProveedor
    {
        public List<ServicioProveedorBO> Listar()
        {
            daoServicioProveedor dao = new daoServicioProveedor();
            return dao.Listar();
        }

        public string Actualizar(ServicioProveedorBO dto)
        {
            daoServicioProveedor dao = new daoServicioProveedor();
            return dao.Actualizar(dto);
        }

        public string Eliminar(int dto)
        {
            daoServicioProveedor dao = new daoServicioProveedor();
            return dao.Eliminar(dto);
        }

        public string Insertar(ServicioProveedorBO dto)
        {
            daoServicioProveedor dao = new daoServicioProveedor();
            return dao.Insertar(dto);
        }
    }
}
