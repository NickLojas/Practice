using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockDatabase
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {
            try
            {
                if (string.IsNullOrEmpty(connectionString))
                    throw new InvalidOperationException("Connection string must NOT be null or empty.");
            }
            catch (InvalidOperationException err)
            {
                Console.WriteLine(err.Message);
            }
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Connection with the Oracle Database has been succesfully OPENED.");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Connection with the Oracle Database has been succesfully CLOSED.");
        }
    }
}
