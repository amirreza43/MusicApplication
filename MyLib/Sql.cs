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

        public static void QueryMinLengthSongs(int songLength){
            using var connection = new SqliteConnection("Data Source=./MyLib/data/database.db");
            connection.Open();
            var command = connection.CreateCommand();

            command.CommandText = @"
                select *
                from songs
                where length > $songLength
            ";

            command.Parameters.AddWithValue("$songLength", songLength);

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
        public static void QueryAnArtist(string artistName){
            using var connection = new SqliteConnection("Data Source=./MyLib/data/database.db");
            connection.Open();
            var command = connection.CreateCommand();

            command.CommandText = @"
                select *
                from artists
                where name = $artistName
            ";

            command.Parameters.AddWithValue("$artistName", artistName);

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var id = reader.GetInt32(0);
                var name = reader.GetString(1);
               

                Console.WriteLine($"id: {id}, artist name: {name}");
            }
        }
        public static void QuerySongsByArtist(string artistName){
            using var connection = new SqliteConnection("Data Source=./MyLib/data/database.db");
            connection.Open();
            var command = connection.CreateCommand();

            command.CommandText = @"
                Select alb.name, song.name, song.genre, song.length, art.name
                From albums as alb
                JOIN songs as song 
                on song.album_id = alb.id
                Join artists as art 
                on alb.artist_id = art.id
                where art.name = $artistName
            ";

            command.Parameters.AddWithValue("$artistName", artistName);

            using var reader = command.ExecuteReader();

            Console.WriteLine("Song list:");

            while (reader.Read())
            {
                var albumName = reader.GetString(0);
                var sName = reader.GetString(1);
                var songGenre = reader.GetString(2);
                var songLength = reader.GetString(3);
                var artName = reader.GetString(4);
               

                Console.WriteLine($"Song name: {sName}, genre: {songGenre}, length: {songLength}, Artist: {artName}");
            }
        }
        public static void QueryTotalSongsByArtist(string artistName){
            using var connection = new SqliteConnection("Data Source=./MyLib/data/database.db");
            connection.Open();
            var command = connection.CreateCommand();

            command.CommandText = @"
                Select count(song.name) as Song_Names
                From albums as alb
                JOIN songs as song 
                on song.album_id = alb.id
                Join artists as art 
                on alb.artist_id = art.id
                where art.name = $artistName
            ";

            command.Parameters.AddWithValue("$artistName", artistName);

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var songCount = reader.GetInt32(0);

                Console.WriteLine($"Total songs by {artistName}: {songCount}");
            }

            
        }

        public static void QuerySongsByGenre(string genre){
            using var connection = new SqliteConnection("Data Source=./MyLib/data/database.db");
            connection.Open();
            var command = connection.CreateCommand();

            command.CommandText = @"
                Select * 
                From Songs
                where genre = $genre
            ";

            command.Parameters.AddWithValue("$genre", genre);

            using var reader = command.ExecuteReader();

            Console.WriteLine("Song list:");

            while (reader.Read())
            {
                var id = reader.GetInt32(0);
                var name = reader.GetString(1);
                var genre1 = reader.GetString(2);
                var length = reader.GetInt32(3);

                Console.WriteLine($"id: {id}, song name: {name}, genre: {genre1}, length: {length}s");
            }
        }

        public static void QueryTotalSongsByAlbums(string albumName){
            using var connection = new SqliteConnection("Data Source=./MyLib/data/database.db");
            connection.Open();
            var command = connection.CreateCommand();

            command.CommandText = @"
                Select count(song.name)
                From albums as alb
                JOIN songs as song 
                on song.album_id = alb.id
                where alb.name = $albumName
            ";

            command.Parameters.AddWithValue("$albumName", albumName);

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var albCount = reader.GetInt32(0);

                Console.WriteLine($"Total songs by the album, {albumName}: {albCount}");
            }

            
        }
    }
}
