using Dataacces;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_Layer
{
    public class NegEstado
    {
        public List<EstadoBO> Listar()
        {
            daoEstado dao = new daoEstado();
            return dao.Listar();
        }

        public string Actualizar(EstadoBO dto)
        {
            daoEstado dao = new daoEstado();
            return dao.Actualizar(dto);
        }

        public string Eliminar(int dto)
        {
            daoEstado dao = new daoEstado();
            return dao.Eliminar(dto);
        }

        public string Insertar(EstadoBO dto)
        {
            daoEstado dao = new daoEstado();
            return dao.Insertar(dto);
        }
    }
}
