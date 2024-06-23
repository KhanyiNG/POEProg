using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Semster2Prog
{
    public class ConnectionData
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Given Artii\Documents\ProgT2\Semster2Prog\Database111.mdf;Integrated Security=True;Connect Timeout=30");
        }
    }
}

