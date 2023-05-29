using System.Data.SqlClient;

namespace DashboardApp.Db
{
  public abstract class DbConnection
    {
        private readonly string connectionString;

        public DbConnection()
        {
            connectionString = "Server=localhost; DataBase=Northwind; Integrated Security=true";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
