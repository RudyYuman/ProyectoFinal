using Dataacces;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_Layer
{
    public class NegSeriePastel
    {
        public List<SeriePasteBO> Listar()
        {
            daoSeriePastel dao = new daoSeriePastel();
            return dao.Listar();            
        }
    }
}
