using MathGameProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameProgram
{
    internal class GameEngine
    {

        internal void AdditionGame()
        {
            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Addition Game");
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);


                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var result = Helpers.ValidateResult();

           
                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer is correct! Type any key for the next question");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer is incorrect. Type any key for the next question");
                    Console.ReadLine();
                }


            }



            Console.WriteLine($"your score was {score}/5 \nPress any key to go back to the main menu.");
            Console.ReadLine();

            Helpers.AddToHistory(score, GameType.Addition);
        }

         internal void DivisionGame()
        {
            var score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Division Game");

                var divisionNumbers = Helpers.GetDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");

                var result = Helpers.ValidateResult();

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer is correct! Type any key for the next question");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer is incorrect. Type any key for the next question");
                    Console.ReadLine();
                }


            }

            Console.WriteLine($"your score was {score}/5 \nPress any key to go back to the main menu.");
            Console.ReadLine();
            Helpers.AddToHistory(score, GameType.Division);
        }

        internal void MultiplicationGame()
        {

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Multiplication Game");
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);


                Console.WriteLine($"{firstNumber} x {secondNumber}");
                var result = Helpers.ValidateResult();

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer is correct! Type any key for the next question");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer is incorrect. Type any key for the next question");
                    Console.ReadLine();
                }

            }

            Console.WriteLine($"your score was {score}/5 \nPress any key to go back to the main menu.");
            Console.ReadLine();
            Helpers.AddToHistory(score, GameType.Multiplication);

        }

        internal void SubtractionGame()
        {
            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Addition Game");

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);


                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var result = Helpers.ValidateResult();

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer is correct! Type any key for the next question");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer is incorrect. Type any key for the next question");
                    Console.ReadLine();
                }

            }

            Console.WriteLine($"your score was {score}/5 \nPress any key to go back to the main menu.");
            Console.ReadLine();
            Helpers.AddToHistory(score, GameType.Subtraction);
        }
    }
}
