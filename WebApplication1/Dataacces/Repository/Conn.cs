using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataacces.Repository
{
    public class Conn
    {
        public string strOracle = string.Empty;
        public Conn(string user, string pass)
        {
            //strOracle = ConfigurationManager.ConnectionStrings["oracleConex"].ConnectionString;

            string usuario = user;
            string password = pass;

            strOracle = "User Id=" + usuario + " ; Password=" + password + " ; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = MASDEL-EMEJIA.MASDEL.local)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = XE)));";


        }
    }
}
