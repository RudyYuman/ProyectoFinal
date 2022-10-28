using Dataacces;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_Layer
{
    public class NegMarca
    {
        public List<MarcaBO> Listar()
        {
            daoMarca dao = new daoMarca();
            return dao.Listar();
        }

        public string Actualizar(MarcaBO dto)
        {
            daoMarca dao = new daoMarca();
            return dao.Actualizar(dto);
        }

        public string Eliminar(int dto)
        {
            daoMarca dao = new daoMarca();
            return dao.Eliminar(dto);
        }

        public string Insertar(MarcaBO dto)
        {
            daoMarca dao = new daoMarca();
            return dao.Insertar(dto);
        }

    }
}

