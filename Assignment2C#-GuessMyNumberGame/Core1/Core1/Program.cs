// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rand = new Random();
            string welcome;
            int num;
            int tries;
            bool playAgain = true;
            var response = "";
            
            while (playAgain)
            {
                var guess = 0;
                tries = 0;
                welcome = "Guess a number between 1 and 100";
                num = rand.Next(1, 101);
                Console.WriteLine(welcome);

                response = "";

                while (guess != num)
                {
                    Console.Write("Guess: ");
                    var input = Console.ReadLine();
                    while (!int.TryParse(input, out guess))
                    {
                        Console.WriteLine("That's not a number.");
                        Console.WriteLine("Enter a number between 1 and 100");
                        input = Console.ReadLine();
                        if (int.TryParse(input, out guess))
                        {
                            Console.WriteLine($"{guess} is better");
                            continue;
                        }
                    }

                    if (guess > num)
                    {
                        Console.WriteLine("Too High");
                        tries++;
                        continue;
                    }
                    else if (guess < num)
                    {
                        Console.WriteLine("Too Low");
                        tries++;
                        continue;
                    }
                    else if (guess == num)
                    {
                        Console.WriteLine("Correct");
                        tries++;
                        continue;
                    }
                }
                Console.WriteLine("You guessed it! The number was {0}!", num);
                //Console.WriteLine("Congrats, it took you " + tries + " tries");
                Console.WriteLine("It took you {0} {1}.\n", tries, tries == 1 ? "try" : "tries");
                //Console.ReadLine();

                Console.WriteLine("Would you like to play again (Yes/No): ");
                response = Console.ReadLine();
                while (string.IsNullOrEmpty(response) || string.IsNullOrWhiteSpace(response))
                {
                    Console.WriteLine("Response can't be empty! Input your response once more");
                    response = Console.ReadLine();
                }
                response = response.ToUpper();

                if (response == "YES")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }

            }
            Console.WriteLine("Thanks for playing!");
            //Console.ReadKey();
        }
    }
}