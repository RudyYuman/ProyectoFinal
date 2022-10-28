using Dataacces;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_Layer
{
    public class NegPersona
    {
        public List<PersonaBO> Listar()
        {
            daoPersona dao = new daoPersona();
            return dao.Listar();
        }

        public string Actualizar(PersonaBO dto)
        {
            daoPersona dao = new daoPersona();
            return dao.Actualizar(dto);
        }

        public string Eliminar(int dto)
        {
            daoPersona dao = new daoPersona();
            return dao.Eliminar(dto);
        }

        public string Insertar(PersonaBO dto)
        {
            daoPersona dao = new daoPersona();
            return dao.Insertar(dto);
        }
    }
}
