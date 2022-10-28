using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataacces.Repository
{
    public class OracleConexion
    {
        public string strOracle = string.Empty;
        public OracleConexion()
        {
            strOracle = ConfigurationManager.ConnectionStrings["oracleConex"].ConnectionString;
                       
        }

    }

}
