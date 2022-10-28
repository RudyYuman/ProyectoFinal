using Dataacces;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_Layer
{
    public class NegControlPago
    {
        public List<ControlPagoBO> Listar()
        {
            daoControlPago dao = new daoControlPago();
            return dao.Listar();
        }

        public string Actualizar(ControlPagoBO dto)
        {
            daoControlPago dao = new daoControlPago();
            return dao.Actualizar(dto);
        }

        public string Eliminar(int dto)
        {
            daoControlPago dao = new daoControlPago();
            return dao.Eliminar(dto);
        }

        public string Insertar(ControlPagoBO dto)
        {
            daoControlPago dao = new daoControlPago();
            return dao.Insertar(dto);
        }
    }
}
