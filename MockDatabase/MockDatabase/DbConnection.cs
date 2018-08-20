using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockDatabase
{
    abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get; private set; }

        protected DbConnection(string connectionString)
        {
            ConnectionString = connectionString;
            Timeout = new TimeSpan(0, 0, 30);
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
