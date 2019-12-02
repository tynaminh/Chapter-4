using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter
{
    class Program
    {
        static void Main(string[] args)
        {
            string entry;
            Console.WriteLine("Please enter you message");
            entry = Console.ReadLine();

            if (entry.Length <= 140)
            {
                Console.WriteLine("The length of your message is acctable" + entry.Length);
            }
            else
            {
                Console.WriteLine("Message to long" + entry.Length);
            }
        }
    }
}
