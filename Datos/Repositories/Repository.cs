using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Datos.Repositories
{
    public abstract class Repository
    {
        private readonly string ConnectionString;

        public Repository()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
