using System;

namespace CheckCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            int userEntry;

            Console.WriteLine("Please enter purchase price. >>>");
            userEntry = Convert.ToInt32(Console.ReadLine());

            if (userEntry > 5000)
            {
                Console.WriteLine("The purchase price " + userEntry + "is greater than allowed.");
            }
            else
            {
                Console.WriteLine("Price approved" + userEntry);
            }
        }
    }
}
