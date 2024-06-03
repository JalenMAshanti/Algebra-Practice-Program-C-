using MathGameProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameProgram
{
    internal class Helpers
    {
        internal static List<Game> games = new List<Game>();

        internal static void AddToHistory(int gameScore, string gameType)
        {
            games.Add(new Game 
            { 
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType
            });
        }



       internal static int[] GetDivisionNumbers()
        {
            var random = new Random();
            var firstNumber = random.Next(1, 99);
            var secondNumber = random.Next(1, 99);

            while (firstNumber % secondNumber != 0)
            {

                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);

            }

            var result = new int[2];
            result[0] = firstNumber;
            result[1] = secondNumber;



            return result;
        }

        internal static void PrintGames()
        {

            Console.Clear();
            Console.WriteLine("Game History");
            Console.WriteLine("-------------------------------");

            if (games.Count == 0)
            {
                 Console.WriteLine("No games have been found");
            }
            else { 
            
                foreach (var game in games)
                {

                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}pts");

                }
            
            
            }          
            Console.WriteLine("------------------------------\n");
            Console.WriteLine("Press Any Key to go back to the main menu");
            Console.ReadLine();

        }
    }
}
