using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guess;
            bool correct = false;
            Random random = new Random();
            int num = random.Next(0,100);
           
            do
            {
                
                Console.WriteLine("Guess my number which is between 0 and 100");
                guess = int.Parse(Console.ReadLine());

                if (guess == num)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct");
                    correct = true;
                    Console.ResetColor();
                }
                else if (guess < num)
                {
                    Console.WriteLine("Number is greater than the guessed number");
                }
                else if (guess > num) {
                    Console.WriteLine("Number is lesser than the guessed number");
                }

            } while (!correct);

            Console.ReadLine();
        }
    }
}
