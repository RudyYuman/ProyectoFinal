using Dataacces;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_Layer
{
    public class NegColor
    {
        public List<ColorBO> Listar()
        {
            daoColor dao = new daoColor();
            return dao.Listar();
        }

        public string Actualizar(ColorBO dto)
        {
            daoColor dao = new daoColor();
            return dao.Actualizar(dto);
        }

        public string Eliminar(int dto)
        {
            daoColor dao = new daoColor();
            return dao.Eliminar(dto);
        }

        public string Insertar(ColorBO dto)
        {
            daoColor dao = new daoColor();
            return dao.Insertar(dto);
        }
    }
}
