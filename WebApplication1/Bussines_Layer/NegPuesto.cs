using Dataacces;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_Layer
{
    public class NegPuesto
    {
        public List<PuestoBO> Listar()
        {
            daoPuesto dao = new daoPuesto();
            return dao.Listar();
        }

        public string Actualizar(PuestoBO dto)
        {
            daoPuesto dao = new daoPuesto();
            return dao.Actualizar(dto);
        }

        public string Eliminar(int dto)
        {
            daoPuesto dao = new daoPuesto();
            return dao.Eliminar(dto);
        }

        public string Insertar(PuestoBO dto)
        {
            daoPuesto dao = new daoPuesto();
            return dao.Insertar(dto);
        }
    }
}
