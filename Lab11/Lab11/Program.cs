using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movies> movies = new List<Movies>();
            movies.Add(new Movies("Guardians of the Galaxy", "Sci-Fi"));
            movies.Add(new Movies("Return of the Jedi", "Sci-Fi"));
            movies.Add(new Movies("Alien", "Sci-Fi"));
            movies.Add(new Movies("Old School", "Comedy"));
            movies.Add(new Movies("Animal House", "Comedy"));
            movies.Add(new Movies("Wedding Crashers", "Comedy"));
            movies.Add(new Movies("Christine", "Horror"));
            movies.Add(new Movies("Children of the Corn", "Horror"));
            movies.Add(new Movies("Scream", "Horror"));
            movies.Add(new Movies("Friday the 13th", "Horror"));
            movies.Add(new Movies("The Little Mermaid", "Animated"));
            movies.Add(new Movies("Shrek", "Animated"));
            movies.Add(new Movies("Pocohantas", "Animated"));
            string[] Categories = { "Horror", "Sci-Fi", "Animated", "Comedy" };
            Console.WriteLine("Welcome to the Movie List Application");
            int menuChoice;
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Pick a Category");
                Console.WriteLine("Horror(1) Sci-Fi(2) Animated(3) Comedy(4)");
                menuChoice = MenuInput();

                foreach (Movies c in movies)
                {
                    if (c.Category == Categories[menuChoice - 1])
                    {
                        Console.WriteLine(c.MovieName);
                    }
                }
                repeat = Continue("New Category? Y/N");
            }
        }
        private static int MenuInput()
        {
            int menuChoice;
            while (!int.TryParse(Console.ReadLine(), out menuChoice) || menuChoice < 1 || menuChoice > 4)
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine("Please choose a number from 1 - 4");
            }

            return menuChoice;
        }
        public static bool Continue(string Message)
        {
            while (true)
            {
                Console.WriteLine(Message);
                string input = Console.ReadLine().ToUpper();
                if (input == "N")
                {
                    return false;
                }
                else if (input == "Y")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid input, try again");
                }
            }
        }
    }
}

