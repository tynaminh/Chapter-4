using System;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rndNumber = rnd.Next(1, 10); // creates a number between 1 and 10
            int userEntry;
            string choice;
            Console.WriteLine("please enter a number between 1 amd 10");
            userEntry = Convert.ToInt32(Console.ReadLine());

            if (userEntry == rndNumber)
            {
                Console.WriteLine("How did you know it waqs {0}?", userEntry);
                Console.WriteLine("Would you like to go for double or nothing?");
                choice = Console.ReadLine();
                if (choice.Equals("Yes"))
                {
                    Console.WriteLine("Congraulations you are a degenerate gambler.");
                }
                else
                {
                    Console.WriteLine("Way to quit when you are ahead");
                }
            }
            else
            {
                Console.WriteLine("{0} that was incorrect. ", userEntry);
            }
        }
    }
}
