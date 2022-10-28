using Dataacces;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_Layer
{
    public class NegProveedor
    {
        public List<ProveedorBO> Listar()
        {
            daoProveedor dao = new daoProveedor();
            return dao.Listar();
        }

        public string Actualizar(ProveedorBO dto)
        {
            daoProveedor dao = new daoProveedor();
            return dao.Actualizar(dto);
        }

        public string Eliminar(int dto)
        {
            daoProveedor dao = new daoProveedor();
            return dao.Eliminar(dto);
        }

        public string Insertar(ProveedorBO dto)
        {
            daoProveedor dao = new daoProveedor();
            return dao.Insertar(dto);
        }
    }
}
