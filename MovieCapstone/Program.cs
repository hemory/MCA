using System;
using System.Collections.Generic;

namespace MovieCapstone
{
    class Program
    {
        static void Main(string[] args)
        {

            var x = new MovieRepo();
            //PRINTS OUT THE MENU

            Console.WriteLine("Hello, welcome to the Movie App. Please select an option from the menu below.");
            Console.Title = "MOVIE APP";


            var movieMenu = new Menu();
            movieMenu.ShowMenu();

            var choice = Convert.ToInt32(Console.ReadLine());
            movieMenu.MakeChoice(choice);

        }

    }

  
}



