using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Lab3A
    {
        static void Main(string[] args)
        {
            string path = "..//..//Data.txt";
            List<Media> media = ReadData(path);

            bool running = true;

            while (running)
            {
                string choice = DisplayMenu();

                switch (choice)
                {
                    case "1":
                        ListBooks(media);
                        break;
                    case "2":
                        ListMovies(media);
                        break;
                    case "3":
                        ListSongs(media);
                        break;
                    case "4":
                        ListAllMedia(media);
                        break;
                    case "5":
                        Console.WriteLine("5");
                        break;
                    case "6":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice please enter a number between 1 to 6.");
                        break;
                }
            }
        }

        static List<Media> ReadData(string path)
        {
            List<Media> media = new List<Media>();

            try
            {
                StreamReader reader = new StreamReader(path);
                
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (line != "-----" && line.Trim() != "")
                    {
                        string[] explode = line.Split('|');

                        string type = explode[0];
                        string title = explode[1];
                        int year = int.Parse(explode[2]);

                        // Every line after the header, up to "-----"
                        List<string> rest = ReadRestOfFile(reader);

                        if (type == "SONG")
                        {
                            string album = explode[3];
                            string artist = explode[4];
                            foreach (string extra in rest)
                            {
                                artist += " " + extra;
                            }
                            Song song = new Song(title, year, album, artist);
                            media.Add(song);
                        }else
                        {
                            string person = explode[3];   // Author or Director
                            string summary = "";

                            foreach (string extra in rest)
                            {
                                // A single word before the summary is part of a wrapped name (e.g. "Richter")
                                if (summary == "" && !extra.Contains(" "))
                                {
                                    person += " " + extra;
                                }
                                else
                                {
                                    summary += extra + " ";
                                }
                                   
                            }

                            if (type == "BOOK")
                            {
                                Book book = new Book(title, year, person, summary);
                                media.Add(book);
                            }else if(type == "MOVIE")
                            {
                                Movie movie = new Movie(title, year, person, summary);
                                media.Add(movie);
                            }
                        }

                    }
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return media;
        }

        /// <summary>
        /// Reads lines until "-----" or the end of the file
        /// </summary>
        static List<string> ReadRestOfFile(StreamReader reader)
        {
            List<string> lines = new List<string>();
            string line = reader.ReadLine();

            while (line != null && line != "-----")
            {
                lines.Add(line.Trim());
                line = reader.ReadLine();
            }

            return lines;
        }

        static string DisplayMenu()
        {
            string choice;
            Console.WriteLine();
            Console.WriteLine("1. List All Books");
            Console.WriteLine("2. List All Movies");
            Console.WriteLine("3. List All Songs");
            Console.WriteLine("4. List All Media");
            Console.WriteLine("5. Search All Media by Title");
            Console.WriteLine("6. Exit Program");
            Console.Write("Enter choice: ");
            choice = Console.ReadLine();
            Console.WriteLine();
            return choice;
        }


        static void ListBooks(List<Media> media)
        {
            Console.WriteLine($"{"Title",-45}{"Year",-6}{"Author",-2}");
            Console.WriteLine(new string('-', 70));

            foreach (Media item in media)
            {
                if (item is Book)
                {
                    Book book = (Book)item;
                    Console.WriteLine($"{book.Title,-45}{book.Year,-6}{book.Author,-2}");
                }
            }
        }

        static void ListMovies(List<Media> media)
        {
            Console.WriteLine($"{"Title",-60}{"Year",-6}{"Director",-5}");
            Console.WriteLine(new string('-', 85));

            foreach (Media item in media)
            {
                if (item is Movie)
                {
                    Movie movie = (Movie)item;
                    Console.WriteLine($"{movie.Title,-60}{movie.Year,-6}{movie.Director,-2}");
                }
            }
        }

        static void ListSongs(List<Media> media)
        {
            Console.WriteLine($"{"Title",-33}{"Year",-6}{"Album",-28}{"Artist",-32}");
            Console.WriteLine(new string('-', 100));

            foreach (Media item in media)
            {
                if (item is Song)
                {
                    Song song = (Song)item;
                    Console.WriteLine($"{song.Title,-33}{song.Year,-6}{song.Album,-28}{song.Artist,-30}");
                }
            }
        }

        static void ListAllMedia(List<Media> media)
        {
            foreach (Media item in media)
                Console.WriteLine(item);   // ToString() in each class, no summary
        }
    }
}
