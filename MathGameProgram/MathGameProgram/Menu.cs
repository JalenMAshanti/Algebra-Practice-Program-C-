using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameProgram
{
    internal class Menu
    {
        GameEngine engine = new();
        internal void ShowMenu(string name, DateTime date)
        {

            Console.WriteLine("__________________________________________________");
            Console.WriteLine($"Hello {name.ToUpper()}. Its {date.DayOfWeek}. This is your math game. That's a great that you're working on improving yourself!");
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
            

            var isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine("What game would you like to play today? Choose from the options below:");
                Console.WriteLine("V - View Previous Games");
                Console.WriteLine("A - Addition");
                Console.WriteLine("S - Subtraction");
                Console.WriteLine("M - Multiplication");
                Console.WriteLine("D - Division");
                Console.WriteLine("Q - Quit the program");
                Console.WriteLine("__________________________________________________");

                var gameSelected = Console.ReadLine().ToUpper().Trim();

                switch (gameSelected)
                {
                    case "V":
                        Helpers.PrintGames();
                        break;

                    case "A":

                        engine.AdditionGame();
                        break;

                    case "S":

                        engine.SubtractionGame();
                        break;

                    case "M":

                        engine.MultiplicationGame();
                        break;

                    case "D":

                        engine.DivisionGame();
                        break;

                    case "Q":

                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        break;

                    default:
                        Console.WriteLine("invalid input");
                        break;

                }

            } while (isGameOn);


        }


    }
}
