using Dataacces;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_Layer
{
    public class NegMunicipio
    {
        public List<MunicipioBO> Listar()
        {
            daoMunicipio dao = new daoMunicipio();
            return dao.Listar();
        }

        public string Actualizar(MunicipioBO dto)
        {
            daoMunicipio dao = new daoMunicipio();
            return dao.Actualizar(dto);
        }

        public string Eliminar(int dto)
        {
            daoMunicipio dao = new daoMunicipio();
            return dao.Eliminar(dto);
        }

        public string Insertar(MunicipioBO dto)
        {
            daoMunicipio dao = new daoMunicipio();
            return dao.Insertar(dto);
        }
    }
}
