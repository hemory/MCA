using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MovieCapstone
{
    public class Menu
    {
        public void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("1='Show Movie List', 2='Find a movie', 3='Find movie by actor', 4='Add Movie'");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine();
        }

        public void MakeChoice(int choice)
        {
            var menu = new Menu();
            var movie = new MovieRepo();
            var userInput = string.Empty;
            switch (choice)
            {
                case 1:
                    movie.ReadMovieFile();
                    menu.MakeAnotherSelection();
                    break;
                case 2:
                    menu.FindMovieByTitle(userInput);
                    menu.MakeAnotherSelection();
                    break;
                case 3:
                    menu.FindMovieByActor(userInput);
                    menu.MakeAnotherSelection();
                    break;
                case 4:
                    movie.WriteMovieFile();
                    menu.MakeAnotherSelection();
                    break;
                default:
                    Console.WriteLine("Unknown command");
                    break;
            }
        }

        public void MakeAnotherSelection()
        {
            Console.WriteLine("Would you like to conintue Y/N? ");
            var userInput = Console.ReadLine().ToLower();


            if (userInput == "y")
            {
                //var movieMenu = new Menu();
                ShowMenu();
                var choice = Convert.ToInt32(Console.ReadLine());
                MakeChoice(choice);
                //MakeAnotherSelection();
            }
            else
            {
                Console.WriteLine("Thank you for choosing Move App!");
            }

        }

        public void FindMovieByTitle(string title)
        {           
            Console.WriteLine("Enter the title of the movie you wish to find: ");
            title = Console.ReadLine();
            var movies = new Movie();

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


            var result = archive.Find(x => x.Title.ToUpper() == title.ToUpper());
            if (result == null)
            {
                Console.WriteLine($"Cant find the movie called {title}");
            }
            else
            {

                Console.WriteLine($" Title: {result.Title} Actor: {result.Actor} Genre: {result.Genre} Director: {result.Director}");

            }
        }

        public void FindMovieByActor(string actor)
        {
            Console.WriteLine("Enter an actor you wish to find: ");
            actor = Console.ReadLine();
            var movies = new Movie();

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
                     
            var actorResult = archive.FindAll(x => x.Actor.ToUpper() == actor.ToUpper());
            if (actorResult ==null)
            {
                Console.WriteLine($"Cant find the movie called {actor}");
            }
            else
            {
                foreach (var result in actorResult)
                {
                    Console.WriteLine($"Title: {result.Title} Actor: {result.Actor} Genre: {result.Genre} Director: {result.Director}");
                }

            }



        }
              
    }
}
  


