using Dataacces;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_Layer
{
    public class NegSede
    {
        public List<SedeBO> Listar()
        {
            daoSede dao = new daoSede();
            return dao.Listar();
        }

        public string Actualizar(SedeBO dto)
        {
            daoSede dao = new daoSede();
            return dao.Actualizar(dto);
        }

        public string Eliminar(int dto)
        {
            daoSede dao = new daoSede();
            return dao.Eliminar(dto);
        }

        public string Insertar(SedeBO dto)
        {
            daoSede dao = new daoSede();
            return dao.Insertar(dto);
        }
    }
}
