using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlDB = new SqlConnection("SQLconnect2018");
            sqlDB.OpenConnection();
            sqlDB.CloseConnection();

            Console.WriteLine();
            var oracleDB = new OracleConnection("Oracleconnect2018");
            oracleDB.OpenConnection();
            oracleDB.CloseConnection();

            Console.WriteLine();
            var nullSqlDB = new SqlConnection(null);
            var emptyOracleDB = new OracleConnection("");
        }
    }
}
