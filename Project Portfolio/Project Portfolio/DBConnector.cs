namespace DBconnection
{
    public class DBconnection
    {
        private string connectionString;
        
        public DBconnection (string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void OpenConnection()
        {
            using var conn = new NpgsqlConnection(connectionString);
            conn.Open(); //connect to DB
        }

        public void CloseConnection()
        {
            conn.Close();
        }
        
        public void ConnectionCommand(string commandString)
        {
            cmd.Connection = conn;
            cmd.CommandText = commandString;
            var reader = cmd.ExecuteReader();
        }
    }
    
}