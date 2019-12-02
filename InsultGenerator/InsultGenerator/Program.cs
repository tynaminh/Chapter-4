using System;

namespace InsultGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int enterAge;
            String result = null;
            Console.WriteLine("Please enter an age so I can make fun of you!!");
            Console.WriteLine("if you call me a boomer you might die of old age.");
            enterAge = Convert.ToInt32(Console.ReadLine());

            if (enterAge <= 12)
            {
                result = "You are just a young punk.";
            }
            else if (enterAge > 12 && enterAge <= 17)
            {
                result = "Your generation is the problem";
            }
            else if (enterAge > 17 && enterAge <= 25)
            {
                result = "How's living in your parents' basement?";
            }
            else if (enterAge > 26 && enterAge <= 35)
            {
                result = "How's the college debt?";
            }
            else if (enterAge > 46 && enterAge <= 54)
            {
                result = "Slow down grandpa! You're going to break a hip!";
            }
            else if (enterAge > 55 && enterAge <= 62)
            {
                result = "Do I need to chew your food for you?";
            }
        }
    }
}
