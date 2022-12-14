using Dataacces;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_Layer
{
    public class NegVehiculo
    {
        public List<VehiculoBO> Listar()
        {
            daoVehiculo dao = new daoVehiculo();
            return dao.Listar();
        }

        public string Actualizar(VehiculoBO dto)
        {
            daoVehiculo dao = new daoVehiculo();
            return dao.Actualizar(dto);
        }

        public string Eliminar(int dto)
        {
            daoVehiculo dao = new daoVehiculo();
            return dao.Eliminar(dto);
        }

        public string Insertar(VehiculoBO dto)
        {
            daoVehiculo dao = new daoVehiculo();
            return dao.Insertar(dto);
        }

    }
}

