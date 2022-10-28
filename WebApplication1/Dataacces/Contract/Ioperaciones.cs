using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataacces.Contract
{
    public interface Ioperaciones<T>
    {
        string Insertar(T dto);
        string Actualizar(T dto);           
        string Eliminar(int dto);
        List<T> Listar();

    }
}
