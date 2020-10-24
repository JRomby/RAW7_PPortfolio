using Npgsql;

namespace DBconnection
{
    public class DBconnection
    {
        private string connectionString;
        private NpgsqlConnection conn;
        
        public DBconnection (string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void OpenConnection()
        {
            conn = new NpgsqlConnection(connectionString);
            conn.Open(); //connect to DB
        }

        public void CloseConnection()
        {
            conn.Close();
        }
        
        public void ConnectionCommand(string commandString)
        {
            using var command = new NpgsqlCommand();
            command.Connection = conn;
            command.CommandText = commandString;
            var reader = command.ExecuteReader();
        }

        public object ReturnDataTable(string commandString)
        {
            using var command = new NpgsqlCommand();
            command.Connection = conn;
            command.CommandText = commandString;
            NpgsqlDataReader dataReader = command.ExecuteReader();
            return dataReader;
        }
    }
}