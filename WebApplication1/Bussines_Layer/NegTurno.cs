using Dataacces;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_Layer
{
    public class NegTurno
    {
        public List<TurnoBO> Listar()
        {
            daoTurno dao = new daoTurno();
            return dao.Listar();
        }

        public string Actualizar(TurnoBO dto)
        {
            daoTurno dao = new daoTurno();
            return dao.Actualizar(dto);
        }

        public string Eliminar(int dto)
        {
            daoTurno dao = new daoTurno();
            return dao.Eliminar(dto);
        }

        public string Insertar(TurnoBO dto)
        {
            daoTurno dao = new daoTurno();
            return dao.Insertar(dto);
        }
    }
}
