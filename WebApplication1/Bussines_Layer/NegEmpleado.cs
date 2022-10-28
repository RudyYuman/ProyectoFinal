using Dataacces;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_Layer
{
    public class NegEmpleado
    {
        public List<EmpleadoBO> Listar()
        {
            daoEmpleado dao = new daoEmpleado();
            return dao.Listar();
        }

        public string Actualizar(EmpleadoBO dto)
        {
            daoEmpleado dao = new daoEmpleado();
            return dao.Actualizar(dto);
        }

        public string Eliminar(int dto)
        {
            daoEmpleado dao = new daoEmpleado();
            return dao.Eliminar(dto);
        }

        public string Insertar(EmpleadoBO dto)
        { 
            daoEmpleado dao = new daoEmpleado();
            return dao.Insertar(dto);
        }
    }
}
