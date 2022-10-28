using Dataacces;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_Layer
{
    public class NegLinea
    {
        public List<LineaBO> Listar()
        {
            daoLinea dao = new daoLinea();
            return dao.Listar();
        }

        public string Actualizar(LineaBO dto)
        {
            daoLinea dao = new daoLinea();
            return dao.Actualizar(dto);
        }

        public string Eliminar(int dto)
        {
            daoLinea dao = new daoLinea();
            return dao.Eliminar(dto);
        }

        public string Insertar(LineaBO dto)
        {
            daoLinea dao = new daoLinea();
            return dao.Insertar(dto);
        }
    }
}
