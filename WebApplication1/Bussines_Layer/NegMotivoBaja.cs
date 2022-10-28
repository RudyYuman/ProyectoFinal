using Dataacces;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_Layer
{
    public class NegMotivoBaja
    {
        public List<MotivoBajaBO> Listar()
        {
            daoMotivoBaja dao = new daoMotivoBaja();
            return dao.Listar();
        }

        public string Actualizar(MotivoBajaBO dto)
        {
            daoMotivoBaja dao = new daoMotivoBaja();
            return dao.Actualizar(dto);
        }

        public string Eliminar(int dto)
        {
            daoMotivoBaja dao = new daoMotivoBaja();
            return dao.Eliminar(dto);
        }

        public string Insertar(MotivoBajaBO dto)
        {
            daoMotivoBaja dao = new daoMotivoBaja();
            return dao.Insertar(dto);
        }
    }
}
