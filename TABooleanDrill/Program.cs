using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TABooleanDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my favorite color!");
            string guessColor = Console.ReadLine();
            bool correct = guessColor == "blue";

            do
            {
                switch (guessColor)
                {
                    case "green":
                        Console.WriteLine("You guessed green. Try Again.");
                        guessColor = Console.ReadLine();
                        break;
                    case "red":
                        Console.WriteLine("You guessed red. Try Again.");
                        guessColor = Console.ReadLine();
                        break;
                    case "blue":
                        Console.WriteLine("You are correct!");
                        correct = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong. Try Again.");
                        guessColor = Console.ReadLine();
                        break;
                }
            }
            while (!correct);

            Console.WriteLine("Let's do another.");
            Console.WriteLine("How about my favorite number? 1 - 20");
            int favNum = Convert.ToInt32(Console.ReadLine());
            bool correctNum = favNum == 13;

            while (!correctNum)
            {
                switch (favNum)
                {
                    case 12:
                        Console.WriteLine("You guessed 12. Try Again.");
                        favNum = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 13:
                        Console.WriteLine("Good guess. You're Right!");
                        correctNum = true;
                        break;
                    default:
                        Console.WriteLine("Not quite. Try Again.");
                        favNum = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
