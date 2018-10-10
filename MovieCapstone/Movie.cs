using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MovieCapstone
{
    public class Movie
    {
        public string Title { get; set; }
        public string Actor { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }


        //public List<Movie> LoadMovies()
        //{
            //List<Movie> archive = new List<Movie>();
            //List<string> lines = File.ReadAllLines("/Users/hphifer/Desktop/Capstone/MovieList.txt").ToList();

            //foreach (var line in lines)
            //{
            //    string[] entries = line.Split(',');
            //    Movie movie = new Movie
            //    {
            //        Genre = entries[0],
            //        Title = entries[1],
            //        Actor = entries[2],
            //        Director = entries[3]
            //    };
            //    archive.Add(movie);

            //    return archive;
            //}


            //List<Movie> MovieList = new List<Movie>
            //{
            //    new Movie { Title = "THE GREEN MILE", Actor = "GUAM HERNANDEZ", Genre = "FUNNY", Director = "Juan" },
            //    new Movie { Title = "MEN IN BLACK", Actor = "WILL SMITH", Genre = "SAD", Director = "Juan" },
            //    new Movie { Title = "GHOST", Actor = "PATRICK SWAYZE", Genre = "COMEDY", Director = "Juan" },
            //    new Movie { Title = "FAST AND FURIOUS", Actor = "VIN DIESEL", Genre = "DARK", Director = "Juan" },
            //    new Movie { Title = "THE NOTEBOOK", Actor = "RYAN GOSLING", Genre = "ACTION", Director = "Juan" },
            //    new Movie { Title = "JAWS", Actor = "GABRIEL UNION", Genre = "ROMANCE", Director = "Juan" },
            //    new Movie { Title = "TITANIC", Actor = "LEO DECRAPIO", Genre = "CRYBABY", Director = "Juan" }
            //};

            //return MovieList;

        }
    }

