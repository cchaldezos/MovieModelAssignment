using System;
using System.Collections.Generic;

namespace MovieModelAssignment
{
    public class Movie
    {
        public string title { get; set; }

        public int rating { get; set; }

        public decimal earnings { get; set; }

        public string[] actors { get; set; }

        public string[] reviews { get; set; }


        public static void PrintMovies(List<Movie> movies)
        {
            foreach (var item in movies)
            {  
                Console.WriteLine($"Title: {item.title}");
                Console.WriteLine($"Earnings: {item.earnings} $");
                Console.WriteLine($"Rating: {item.rating}");

                Console.WriteLine();
            }
        }
    }



}
