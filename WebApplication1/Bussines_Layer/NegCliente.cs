using Dataacces;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_Layer
{
    public class NegCliente
    {
        public List<ClienteBO> Listar()
        {
            daoCliente dao = new daoCliente();
            return dao.Listar();
        }

        public string Actualizar(ClienteBO dto)
        {
            daoCliente dao = new daoCliente();
            return dao.Actualizar(dto);
        }

        public string Eliminar(int dto)
        {
            daoCliente dao = new daoCliente();
            return dao.Eliminar(dto);
        }

        public string Insertar(ClienteBO dto)
        {
            daoCliente dao = new daoCliente();
            return dao.Insertar(dto);
        }

    }
}
