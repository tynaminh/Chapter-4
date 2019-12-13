using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int ai = rnd.Next(1, 3);
            int userEntry;
            int wins = 0;
            bool again = true;

            Console.WriteLine("Welcome to Rock Paper Scissors ");
            Console.WriteLine("I am your game show host Tron Tricker");
            Console.WriteLine("######################################");
            while (again)
            {
                Console.WriteLine("Enter the following numbers to play: " +
                "\n1 - Rock \n2 - Scissors \n3 - Paper");
                userEntry = Convert.ToInt32(Console.ReadLine());

                if (ai == 1)
                {
                    if (userEntry == 1)
                    {
                        Console.WriteLine("You tied!");
                    }
                    else if (userEntry == 2)
                    {
                        Console.WriteLine("You won!!!");
                        wins = wins + 1;
                    }
                    else
                    {
                        Console.WriteLine("You lost");
                    }
                }
                else if (ai == 2)
                {
                    if (userEntry == 2)
                    {
                        Console.WriteLine("You won!");
                        wins = wins + 1;
                    }
                    else if (userEntry == 2)
                    {
                        Console.WriteLine("You tied!!!");
                    }
                    else
                    {
                        Console.WriteLine("You lost");
                    }
                }
                else if (ai == 3)
                {
                    if (userEntry == 3)
                    {
                        Console.WriteLine("You lost!");
                    }
                    else if (userEntry == 2)
                    {
                        Console.WriteLine("You won!");
                        wins = wins + 1;
                    }
                    else
                    {
                        Console.WriteLine("You tied!");
                    }
                }
                if (wins == 5)
                {
                    Console.WriteLine("Congrats you have completed the game!");
                    again = false;
                }
                Console.WriteLine("You have won " + wins + " times");
            }
        }
    }
}
