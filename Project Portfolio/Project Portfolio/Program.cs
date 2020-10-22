
using System;
using Npgsql;

namespace Project_Portfolio
{
    class ConnectDB
    {
        static void Main(string[] args)
        {
            string connectionString =
                 ""; //connection info for DB

            using var conn = new NpgsqlConnection(connectionString);
            conn.Open(); //connect to DB

            using var cmd = new NpgsqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = "select categoryid, categoryname from categories";

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"Id={reader.GetInt32(0)}, Name={reader.GetString(1)}");
            }
        }
    }
}
