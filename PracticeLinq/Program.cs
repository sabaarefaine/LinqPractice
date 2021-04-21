using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> favoriteShows = new List<string>
            {"Bobs Burgers", "Handmaids Tale", "The Office", "Curb Your Enthusiasm", "Real Housewives"};


            IEnumerable<string> sortedShows = favoriteShows.OrderBy(x => x.Length);

            foreach (var show in sortedShows)
            {
            Console.WriteLine(show);
            }


            //another way i found to order by
            /*
            var sortedShows = from show in favoriteShows
                              orderby show.Length
                              select show;

            foreach (var x in sortedShows)
            {
                Console.WriteLine(x);
            }
            */
        }
    }
}
