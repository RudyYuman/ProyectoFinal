using Dataacces;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_Layer
{
    public class NegDepartamento
    {
        public List<DepartamentoBO> Listar()
        {
            daoDepartamento dao = new daoDepartamento();
            return dao.Listar();
        }

        public string Actualizar(DepartamentoBO dto)
        {
            daoDepartamento dao = new daoDepartamento();
            return dao.Actualizar(dto);
        }

        public string Eliminar(int dto)
        {
            daoDepartamento dao = new daoDepartamento();
            return dao.Eliminar(dto);
        }

        public string Insertar(DepartamentoBO dto)
        {
            daoDepartamento dao = new daoDepartamento();
            return dao.Insertar(dto);
        }
    }
}
