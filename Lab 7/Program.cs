using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List of Movies
            List<Movie> movieList = new List<Movie>() { };
            Movie movie1 = new Movie();
            movie1.Title = "The Godfather"; movie1.Category = "Drama";

            Movie movie2 = new Movie();
            movie2.Title = "The Godfather Part II"; movie2.Category = "Drama";

            Movie movie3 = new Movie();
            movie3.Title = "Inception"; movie3.Category = "Action";

            Movie movie4 = new Movie();
            movie4.Title = "The Shawshank Redemption"; movie4.Category = "Drama";

            Movie movie5 = new Movie();
            movie5.Title = "The Matrix"; movie5.Category = "Action";

            Movie movie6 = new Movie();
            movie6.Title = "The Good, The Bad, The Ugly"; movie6.Category = "Western";

            Movie movie7 = new Movie();
            movie7.Title = "The Lion King"; movie7.Category = "Animation";

            Movie movie8 = new Movie();
            movie8.Title = "The Aristocats"; movie8.Category = "Animation";

            Movie movie9 = new Movie();
            movie9.Title = "Back to the Future"; movie9.Category = "Comedy";

            Movie movie10 = new Movie();
            movie10.Title = "Modern Times"; movie10.Category = "Comedy";

            movieList.Add(movie1);
            movieList.Add(movie2);
            movieList.Add(movie3);
            movieList.Add(movie4);
            movieList.Add(movie5);
            movieList.Add(movie6);
            movieList.Add(movie7);
            movieList.Add(movie8);
            movieList.Add(movie9);
            movieList.Add(movie10);
            #endregion

            Console.WriteLine("WELCOME TO THE MOVIE LIST APPLICATION!");
            Thread.Sleep(2000);
            Console.Clear();

            bool runningProgram = true;
            while (runningProgram)
            {
                PrintMenuOptions();
                Console.WriteLine("What would you like to do?");
                string decision = Console.ReadLine();
                int number;
                bool confirmedNum = int.TryParse(decision, out number);
                if(confirmedNum)
                {
                    if (number >= 1 && number < 6)
                    {
                        switch (number)
                        {
                            case 1:
                                PrintProgramOverview();
                                Thread.Sleep(5000);
                                Console.Clear();
                                continue;
                            case 2:
                                PrintMovieList(movieList);
                                Thread.Sleep(5000);
                                Console.Clear();
                                continue;
                            case 3:
                                GetMovieByName(movieList, GetUserKeyword());
                                Thread.Sleep(5000);
                                Console.Clear();
                                continue;
                            case 4:
                                GetMovieByCategory(movieList, GetUserCategory());
                                Thread.Sleep(5000);
                                Console.Clear();
                                continue;
                            case 5:
                                break;
                        }
                        runningProgram = false;
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, I didn't recognize a number. Please try again");
                        Console.WriteLine("");
                    }
                }
                else
                {
                    Console.WriteLine("I'm sorry, we didin't recognize that response as a number. Please try again.");
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Thank you for using this program!");
            Console.WriteLine("Have a great day!");
            Console.WriteLine("");
            Environment.Exit(0);
        }

        public static string GetUserCategory()
        {
            Console.WriteLine("What category would you like to see?");
            Console.WriteLine("You can choose ACTION, ANIMATION, COMEDY, DRAMA, or WESTERN.");
            string input = Console.ReadLine();
            return input;
        }
        public static string GetUserKeyword()
        {
            Console.WriteLine("What word would you like to search by?");
            string input = Console.ReadLine();
            return input;
        }
        public static void PrintProgramOverview()
        {
            Console.WriteLine("This application allows you to see a list of movies based on the category.");
        }
        public static void PrintMenuOptions()
        {
            Console.WriteLine("Select from one of the menu options below:");
            Console.WriteLine("============================================");
            Console.WriteLine("Option 1: Get Program Overview");
            Console.WriteLine("Option 2: Print List of All Movies");
            Console.WriteLine("Option 3: Search Movie Titles by Keyword");
            Console.WriteLine("Option 4: Search Movie by Category");
            Console.WriteLine("Option 5: Exit the Program");
            Console.WriteLine("============================================");
            Console.WriteLine("");
        }
        public static void GetMovieByName(List<Movie> moviesList, string input)
        {
            foreach(Movie movie in moviesList)
            {
                if(movie.Title.ToLower().Contains(input))
                {
                    Console.WriteLine($"Title: {movie.Title,-28} Category: {movie.Category}");
                }
            }
        }
        public static void GetMovieByCategory(List<Movie> moviesList, string category)
        {
            foreach(Movie movie in moviesList)
            {
                if(movie.Category.ToLower() == category || movie.Category.ToUpper() == category)
                {
                    Console.WriteLine($"Title: {movie.Title,-28} Category: {movie.Category}");
                }
            }
        }
        public static void PrintMovieList(List<Movie> movieList)
        {
            Console.WriteLine("");
            foreach (Movie movie in movieList)
            {
                string movieInfo = string.Format($"Title: {movie.Title,-28} Category: {movie.Category}");
                Console.WriteLine(movieInfo);
            }
            Console.WriteLine("");
        }
    }
}
