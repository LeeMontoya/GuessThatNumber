using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_That_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int val = r.Next(1, 100);
            int guess = 0;
            bool correct = false;
            int count = 0;
            
            Console.WriteLine("I'm thinking of a number between 1 and 100.");

            while (!correct)
            {
                Console.Write("Guess: ");
                string input = Console.ReadLine();
                count++;

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Is that a number? No. Duh! You silly goose. Try again!");
                    continue;
                }

                if (guess < val)
                {
                    Console.WriteLine("No, the number I'm thinking of is higher than that number.");
                }
                else if (guess > val)
                {
                    Console.WriteLine("No, the number I'm thinking of is lower than that number.");
                }
                else
                {
                    correct = true;
                    Console.WriteLine("You guessed right! It took you " + count + " guess.");
                    Console.ReadKey();
                }
            } 
            
                     
        }
    }
}
