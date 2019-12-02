using System;

namespace DoorGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int userEntry;
            Console.WriteLine("pick a door 1, 2, or 3");
            userEntry = Convert.ToInt32(Console.ReadLine());

            if (userEntry == 1)
            {
                Console.WriteLine("A bucket of sweaty gym socks.");
                
            }
        }
    }
}
