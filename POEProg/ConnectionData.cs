using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace Semster2Prog
{
    public class ConnectionData
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StudentsTBL.mdf;Integrated Security=True");




        }
    }
}

