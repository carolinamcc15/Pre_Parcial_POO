using System;
using System.Data;
using Npgsql;

namespace Pre_Parcial_2
{
    public static class DBConnection
    {
        private static String host = "ec2-34-200-72-77.compute-1.amazonaws.com",
            database = "dckikb6jaeaicl",
            userId = "lvtkqbkpggeboj",
            password = "2bfa20ee93aae26d61d2a7fabab9535c5bee9927a3dc01a4dccf60eb771270c4";

        private static String dbConnection =
            $"Host={host};Port = 5432; User Id = {userId}; Password={password};Database={database};"+ 
            "sslmode=Require;Trust Server Certificate=true";
        
        public static DataTable ExecuteQuery(string query)
        {
            NpgsqlConnection connection = new NpgsqlConnection(dbConnection);
            DataSet dataS = new DataSet();
            connection.Open();
            
            NpgsqlDataAdapter dataA = new NpgsqlDataAdapter(query, connection);
            dataA.Fill(dataS);
            connection.Close();
            
            return dataS.Tables[0];
        }

        public static void ExecuteNonQuery(string action)
        {
            NpgsqlConnection connection = new NpgsqlConnection(dbConnection);
            connection.Open();
            
            NpgsqlCommand command = new NpgsqlCommand(action, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}