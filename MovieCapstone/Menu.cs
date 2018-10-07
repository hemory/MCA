using System;
namespace MovieCapstone
{
    public class Menu
    {
        public void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("1='Show Movie List', 2='Find a movie', 3='Find movie by actor', 4='Quit'");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine();
        }

        public void MakeChoice(int choice)
        {
            var menu = new Menu();
            var movie = new Movie();
            var userInput = string.Empty;
            switch (choice)
            {
                case 1:
                    movie.ShowMovieList();
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
            var movieList = movies.LoadMovies();
            var result = movieList.Find(x => x.Title.ToUpper() == title.ToUpper());
            if (result == null)
            {
                Console.WriteLine($"Cant find the movie called {title}");
            }
            else
            {

                Console.WriteLine($"ID: {result.ID} Title: {result.Title} Actor: {result.Actor} Genre: {result.Genre} Director: {result.Director}");

            }
        }

        public void FindMovieByActor(string actor)
        {
            Console.WriteLine("Enter an actor you wish to find: ");
            actor = Console.ReadLine();
            var movies = new Movie();
            var movieList = movies.LoadMovies();
            var actorResult = movieList.FindAll(x => x.Actor.ToUpper() == actor.ToUpper());
            if (actorResult ==null)
            {
                Console.WriteLine($"Cant find the movie called {actor}");
            }
            else
            {
                foreach (var result in actorResult)
                {
                    Console.WriteLine($"ID: {result.ID} Title: {result.Title} Actor: {result.Actor} Genre: {result.Genre} Director: {result.Director}");
                }

            }



        }
    }
}
  


