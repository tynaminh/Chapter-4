﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int userEntry;

            Console.WriteLine("Please enter a number to determine even or odd >>> ");
            userEntry = Convert.ToInt32(Console.ReadLine());

            if (userEntry % 2 == 0)
            {
                Console.WriteLine("The number " + userEntry + " is even.");
            }
            else
            {
                Console.WriteLine("The number " + userEntry + " is odd.");
            }
        }
    }
}
