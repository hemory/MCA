using System;
using System.Collections.Generic;

namespace MovieCapstone
{
    class Program
    {
        static void Main(string[] args)
        {
            //PRINTS OUT THE MENU

            Console.WriteLine("Hello, welcome to the Movie App. Please select an option from the menu below.");

            var movieMenu = new Menu();
            movieMenu.ShowMenu();
            var choice = Convert.ToInt32(Console.ReadLine());
            movieMenu.MakeChoice(choice);
        }

    }

    #region MOVIECLASS
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Actor { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }

        public List<Movie> LoadMovies()
        {
            //SHOWS A LIST OF MOVIES

            List<Movie> MovieList = new List<Movie>
            {
                new Movie { ID = 1, Title = "THE GREEN MILE", Actor = "GUAM HERNANDEZ", Genre = "FUNNY", Director = "Juan" },
                new Movie { ID = 2, Title = "MEN IN BLACK", Actor = "WILL SMITH", Genre = "SAD", Director = "Juan" },
                new Movie { ID = 3, Title = "GHOST", Actor = "PATRICK SWAYZE", Genre = "COMEDY", Director = "Juan" },
                new Movie { ID = 4, Title = "FAST AND FURIOUS", Actor = "VIN DIESEL", Genre = "DARK", Director = "Juan" },
                new Movie { ID = 5, Title = "THE NOTEBOOK", Actor = "RYAN GOSLING", Genre = "ACTION", Director = "Juan" },
                new Movie { ID = 6, Title = "JAWS", Actor = "GABRIEL UNION", Genre = "ROMANCE", Director = "Juan" },
                new Movie { ID = 7, Title = "TITANIC", Actor = "LEO DECRAPIO", Genre = "CRYBABY", Director = "Juan" }
            };

            return MovieList;

        }

        public void ShowMovieList()
        {
            var movies = new Movie();
            var movieList = movies.LoadMovies();

            foreach (var movie in movieList)
            {
                Console.WriteLine($"ID: {movie.ID} Title: {movie.Title} Actor: {movie.Actor} Genre: {movie.Genre} Director: {movie.Director}");
            }
        }
    }
    #endregion
}



