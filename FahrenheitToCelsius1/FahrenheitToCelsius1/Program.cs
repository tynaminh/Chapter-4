using System;

namespace FahrenheitToCelsius1
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp8AM;
            int temp12PM;
            int temp5PM;
            int temp8AMtoCelsius;
            int temp12PMtoCelsius;
            int temp5PMtoCelsius;

            Console.WriteLine("Please enter the temperature at 8:00am >>> ");
            temp8AM = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the temperature at 12:00pm >>> ");
            temp12PM = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the temperature at 5:00pm >>> ");
            temp5PM = Convert.ToInt32(Console.ReadLine());

            if (temp8AM <= 32 || temp12PM <= 32 || temp5PM <=32) {
                Console.WriteLine("it is freezing");
            }
            else if (temp8AM >= 100 || temp12PM >= 100 || temp5PM >= 100) {
                Console.WriteLine("It is hot.");
            }

            temp8AMtoCelsius = (temp8AM - 32) / (5 / 9);
            temp12PMtoCelsius = (temp12PM - 32) / (5 / 9);
            temp5PMtoCelsius = (temp5PM - 32) / (5 / 9);
            Console.WriteLine("8:00 AM - " + temp8AMtoCelsius);
        }
    }
}
