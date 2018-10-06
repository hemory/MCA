using System;
namespace MovieCapstone
{
    public class Menu
    {
        public void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("1='Show Movie List', 2='Find a movie', 3='Find actor/director', 4='Quit'");
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
            var menu = new Menu();
            Console.WriteLine("Enter the title of the movie you wish to find?");
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
  

         /*   public void AddMovie()
            {
                string title;
                AskforTitle(out title, "Enter the title of the movie: ");


                ProductionYear productionYear;
                AskFor(out productionYear, "When was the movie produced?");

                Movie movie = new Movie(title, productionYear);
                _movieService.Add(movie);

                string name;
                AskFor(out name, "Enter the name of the director.");
                CastOrCrew director = _castOrCrewService.FindBy(name);
                if (director == null)
                {
                    director = NewCastOrCrew(name);
                }

                _castOrCrewService.AddPeople(director);
                movie.Director = director;

                bool keepAskingForNewActor = false;
                do
                {
                    AskFor(out name, "Enter the name of an actor: ");
                    CastOrCrew actor = _castOrCrewService.FindBy(name);
                    if (actor == null)
                    {
                        actor = NewCastOrCrew(name);
                    }
                    _castOrCrewService.AddPeople(actor);
                    movie.AddActor(actor);
                    Console.Write("Do you want to add a new actor to the movie? (y/n)");
                    char c = Console.ReadKey().KeyChar;
                    keepAskingForNewActor = (char.ToLower(c) == 'y');
                    Console.WriteLine();
                } while (keepAskingForNewActor); */

            } 
        }
    

