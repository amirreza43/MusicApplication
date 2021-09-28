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

            // Sql.QueryAllArtists();
            // Sql.QueryAllAlbums();
            // Sql.QueryAllSongs();
            // Sql.QueryMinLengthSongs(180);
            // Sql.QueryAnArtist("Artist A");
            // Sql.QuerySongsByArtist("Artist A");
            // Sql.QueryTotalSongsByArtist("Artist A");
            // Sql.QuerySongsByGenre("Pop");
            // Sql.QueryTotalSongsByAlbums("Album A1");

            while (true)
            {
                Console.WriteLine("Please enter a command.");
                Console.Write("> ");

                var input = Console.ReadLine();
                var splitInput = input.Split(" ");

                if (splitInput.Count() > 0)
                {
                    if (input == "quit")
                    {
                        break;
                    }
                    else if (input == "artists")
                    {
                        Sql.QueryAllArtists();
                    }
                    else if (input == "albums")
                    {
                        Sql.QueryAllAlbums();
                    }
                    else if (input == "songs")
                    {
                        Sql.QueryAllSongs();
                    }
                    else if (splitInput.Length >= 3)
                    {
                        if (splitInput[0] == "songs" && splitInput[1] == "minlength")
                        {
                            Sql.QueryMinLengthSongs(Int32.Parse(splitInput[2]));
                        }
                        else if (splitInput[0] == "albums" && splitInput[1] == "by")
                        {
                            string fullArtistName = "";

                            for (int i = 2; i < splitInput.Length; i++)
                            {
                                fullArtistName += splitInput[i];

                                if (i < splitInput.Length - 1)
                                {
                                    fullArtistName += " ";
                                }
                            }

                            Sql.QueryAnArtist(fullArtistName);
                        }
                        else if (splitInput[0] == "songs" && splitInput[1] == "by")
                        {
                            string fullArtistName = "";

                            for (int i = 2; i < splitInput.Length; i++)
                            {
                                fullArtistName += splitInput[i];

                                if (i < splitInput.Length - 1)
                                {
                                    fullArtistName += " ";
                                }
                            }

                            Sql.QuerySongsByArtist(fullArtistName);
                        }
                        else if (splitInput[0] == "count" && splitInput[1] == "songs" && splitInput[2] == "by")
                        {
                            string fullArtistName = "";

                            for (int i = 3; i < splitInput.Length; i++)
                            {
                                fullArtistName += splitInput[i];

                                if (i < splitInput.Length - 1)
                                {
                                    fullArtistName += " ";
                                }
                            }

                            Sql.QueryTotalSongsByArtist(fullArtistName);
                        }
                        else if (splitInput[0] == "songs" && splitInput[1] == "genre")
                        {
                            Sql.QuerySongsByGenre(splitInput[2]);
                        }
                        else if (splitInput[0] == "count" && splitInput[1] == "songs" && splitInput[2] == "in")
                        {
                            string fullAlbumName = "";

                            for (int i = 3; i < splitInput.Length; i++)
                            {
                                fullAlbumName += splitInput[i];

                                if (i < splitInput.Length - 1)
                                {
                                    fullAlbumName += " ";
                                }
                            }

                            Sql.QueryTotalSongsByAlbums(fullAlbumName);
                        }
                        else
                        {
                            Console.WriteLine("Invalid command.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid command.");
                    }
                }
            }
        }
    }
}
