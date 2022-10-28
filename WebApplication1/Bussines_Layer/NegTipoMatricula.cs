using Dataacces;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_Layer
{
    public class NegTipoMatricula
    {
        public List<TipoMatriculaBO> Listar()
        {
            daoTipoMatricula dao = new daoTipoMatricula();
            return dao.Listar();
        }

        public string Actualizar(TipoMatriculaBO dto)
        {
            daoTipoMatricula dao = new daoTipoMatricula();
            return dao.Actualizar(dto);
        }

        public string Eliminar(int dto)
        {
            daoTipoMatricula dao = new daoTipoMatricula();
            return dao.Eliminar(dto);
        }

        public string Insertar(TipoMatriculaBO dto)
        {
            daoTipoMatricula dao = new daoTipoMatricula();
            return dao.Insertar(dto);
        }

    }
}

