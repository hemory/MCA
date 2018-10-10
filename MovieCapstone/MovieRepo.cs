using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MovieCapstone
{
    public class MovieRepo
    {
        public void ReadMovieFile()
        {
            List<Movie> archive = new List<Movie>();
            List<string> lines = File.ReadAllLines("/Users/hphifer/Desktop/Capstone/MovieList.txt").ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(',');
                Movie movie = new Movie
                {
                    Genre = entries[0],
                    Title = entries[1],
                    Actor = entries[2],
                    Director = entries[3]
                };
                archive.Add(movie);
            }

            foreach (var movie in archive)
            {
                Console.WriteLine($"GENRE:{ movie.Genre } TITLE:{ movie.Title } ACTOR:{ movie.Actor } DIRECTOR{ movie.Director }");
            }

        }

        public void WriteMovieFile()
        {
            List<Movie> archive = new List<Movie>();
            List<string> lines = File.ReadAllLines("/Users/hphifer/Desktop/Capstone/MovieList.txt").ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(',');
                Movie movie = new Movie
                {
                    Genre = entries[0],
                    Title = entries[1],
                    Actor = entries[2],
                    Director = entries[3]
                };
                archive.Add(movie);
            }

            Console.WriteLine("Enter the Genre of the movie.");
            var movieGenre = Console.ReadLine();

            Console.WriteLine("Enter the Title of the movie.");
            var movieTitle = Console.ReadLine();

            Console.WriteLine("Enter the Actor of the movie.");
            var movieActor = Console.ReadLine();

            Console.WriteLine("Enter the Director of the movie.");
            var movieDirector = Console.ReadLine();

            archive.Add(new Movie { Genre = movieGenre, Title = movieTitle, Actor = movieActor, Director = movieDirector });

            List<string> output = new List<string>();

            foreach (var movie in archive)
            {
                output.Add($"{ movie.Genre },{ movie.Title },{ movie.Actor },{ movie.Director }");
            }

            Console.WriteLine("Writing to File....");

            File.WriteAllLines("/Users/hphifer/Desktop/Capstone/MovieList.txt", output);

            Console.WriteLine("New movie added");
        }
    }
}

