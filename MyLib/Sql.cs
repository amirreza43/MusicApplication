using System;
using Microsoft.Data.Sqlite;

namespace MyLib
{
    public class Sql
    {
        public static void QueryAllArtists()
        {
            using var connection = new SqliteConnection("Data Source=./MyLib/data/database.db");
            connection.Open();
            var command = connection.CreateCommand();

            command.CommandText = @"
                select *
                from artists
            ";

            using var reader = command.ExecuteReader();

            Console.WriteLine("Artist list:");

            while (reader.Read())
            {
                var id = reader.GetInt32(0);
                var name = reader.GetString(1);

                Console.WriteLine($"id: {id}, artist name: {name}");
            }
        }

        public static void QueryAllAlbums()
        {
            using var connection = new SqliteConnection("Data Source=./MyLib/data/database.db");
            connection.Open();
            var command = connection.CreateCommand();

            command.CommandText = @"
                select *
                from albums
            ";

            using var reader = command.ExecuteReader();

            Console.WriteLine("Album list:");

            while (reader.Read())
            {
                var id = reader.GetInt32(0);
                var name = reader.GetString(1);

                Console.WriteLine($"id: {id}, album name: {name}");
            }
        }

        public static void QueryAllSongs()
        {
            using var connection = new SqliteConnection("Data Source=./MyLib/data/database.db");
            connection.Open();
            var command = connection.CreateCommand();

            command.CommandText = @"
                select *
                from songs
            ";

            using var reader = command.ExecuteReader();

            Console.WriteLine("Song list:");

            while (reader.Read())
            {
                var id = reader.GetInt32(0);
                var name = reader.GetString(1);
                var genre = reader.GetString(2);
                var length = reader.GetInt32(3);

                Console.WriteLine($"id: {id}, song name: {name}, genre: {genre}, length: {length}s");
            }
        }
    }
}
