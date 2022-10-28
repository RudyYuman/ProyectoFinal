using Dataacces;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_Layer
{
    //cambiar la clase a publica
    //copiar y pegar los metodos de NegCliente y cambiar los datos por los de tabla que estamos trabajando
    public class NegSedeServicio
    {
        public List<SedeServicioBO> Listar()
        {
            daoSedeServicio dao = new daoSedeServicio();
            return dao.Listar();
        }

        public string Actualizar(SedeServicioBO dto)
        {
            daoSedeServicio dao = new daoSedeServicio();
            return dao.Actualizar(dto);
        }

        public string Eliminar(int dto)
        {
            daoSedeServicio dao = new daoSedeServicio();
            return dao.Eliminar(dto);
        }

        public string Insertar(SedeServicioBO dto)
        {
            daoSedeServicio dao = new daoSedeServicio();
            return dao.Insertar(dto);
        }
    }
}
