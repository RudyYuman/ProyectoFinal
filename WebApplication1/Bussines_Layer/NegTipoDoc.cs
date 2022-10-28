using Dataacces;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_Layer
{
    public class NegTipoDoc
    {
        public List<TipoDocBO> Listar()
        {
            daoTipoDoc dao = new daoTipoDoc();
            return dao.Listar();
        }

        public string Actualizar(TipoDocBO dto)
        {
            daoTipoDoc dao = new daoTipoDoc();
            return dao.Actualizar(dto);
        }

        public string Eliminar(int dto)
        {
            daoTipoDoc dao = new daoTipoDoc();
            return dao.Eliminar(dto);
        }

        public string Insertar(TipoDocBO dto)
        {
            daoTipoDoc dao = new daoTipoDoc();
            return dao.Insertar(dto);
        }
    }
}
