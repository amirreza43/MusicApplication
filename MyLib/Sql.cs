using System;
using Microsoft.Data.Sqlite;

namespace MyLib
{
    public class Sql
    {
        public static void QueryArtists()
        {
            using var connection = new SqliteConnection("Data Source=./MyLib/data/database.db");
            connection.Open();
            var command = connection.CreateCommand();

            command.CommandText = @"
                select *
                from artists
            ";

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var id = reader.GetInt32(0);
                var name = reader.GetString(1);

                Console.WriteLine($"id: {id}, name: {name}");
            }
        }
    }
}
