using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Games> gamesList = VideoGames();
            var orderedGames = gamesList.OrderBy(x => x.Name.Length).ToList();
            orderedGames.ForEach(x => Console.WriteLine(x.Name));
        }
        public static List<Games> VideoGames()
        {
            List<Games> output = new List<Games>();
            output.Add(new Games { Name = "The LegendOf Zelda" });
            output.Add(new Games { Name = "Donkey Kong Country" });
            output.Add(new Games { Name = "Sonic The Hedgehog" });
            output.Add(new Games { Name = "Mario Brothers" });
            output.Add(new Games { Name = "Call Of Duty" });


            return output;
        }
    }

}

