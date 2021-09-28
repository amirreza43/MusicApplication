using System;
using MyLib;
using System.Collections.Generic;
using System.Linq;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Sql.QueryAllArtists();
            Sql.QueryAllAlbums();
            Sql.QueryAllSongs();
        }
    }
}
