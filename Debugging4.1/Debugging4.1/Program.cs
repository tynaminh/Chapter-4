﻿using System;

namespace Debugging4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;
            using static System.Console;
        {
            static void Main()
            {
                const double BASIC_DOG_PRICE = 2.00;
                const double CHILI_PRICE = 0.69;
                const double CHEESE_PRICE = 0.49;
                String wantChili, wantCheese;
                double price;

                Console.Write("Do you want chili on your dog? ");
                wantChili = Console.ReadLine();
                Console.Write("Do you want cheese on your dog? ");
                wantCheese = Console.ReadLine();

                    if (wantChili = "Y")
                    {
                        if (wantCheese = "Y")
                }
                        price == BASIC_DOG_PRICE + CHILI_PRICE + CHEESE_PRICE;
                    else
                        price == BASIC_DOG_PRICE + CHILI_PRICE;
                else
                   if (wantCheese = "Y")
                    price = BASIC_DOG_PRICE;
                else
                    price == BASIC_DOG_PRICE;
                Console.WriteLine("Your total is {0}", price.ToString("C"));
            }
        }
    }
}