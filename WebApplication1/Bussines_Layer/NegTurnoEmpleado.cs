using Dataacces;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_Layer
{
    public class NegTurnoEmpleado
    {
        public List<TurnoEmpleadoBO> Listar()
        {
            daoTurnoEmpleado dao = new daoTurnoEmpleado();
            return dao.Listar();
        }

        public string Actualizar(TurnoEmpleadoBO dto)
        {
            daoTurnoEmpleado dao = new daoTurnoEmpleado();
            return dao.Actualizar(dto);
        }

        public string Eliminar(int dto)
        {
            daoTurnoEmpleado dao = new daoTurnoEmpleado();
            return dao.Eliminar(dto);
        }

        public string Insertar(TurnoEmpleadoBO dto)
        {
            daoTurnoEmpleado dao = new daoTurnoEmpleado();
            return dao.Insertar(dto);
        }
    }
}
