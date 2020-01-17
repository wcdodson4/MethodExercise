using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //var userName = Console.ReadLine();
            //Console.WriteLine("What is your favorite animal (plural)?");
            //var favAnimal = Console.ReadLine();
            //Console.WriteLine("What is your favorite band?");
            //var favBand = Console.ReadLine();
            //Console.WriteLine($"Your name is {userName}, and you like to look at pictures of {favAnimal} while listening to {favBand}.");

            //Console.WriteLine("Enter first number.");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter second number.");
            //int y = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter third number.");
            //int z = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"The sum of your numbers is {addNumbers(x, y, z)}.");

            //Console.WriteLine("Enter first number.");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter second number.");
            //double b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"The product of your numbers is {multiplyNumbers(a, b)}.");

            Console.WriteLine(Add(4, 16));
            Console.WriteLine(Add(3.5, 6.9));
            Console.WriteLine(Add(58, 550, true));
            Console.WriteLine(Add(0, 1, false));
        }
        public static int addNumbers(int x, int y, int z)
        {
            return x + y + z;
        }

        public static double multiplyNumbers(double a, double b)
        {
            return a * b;
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static string Add(int p, int q, bool dollars)
        {
            if (dollars == true)
            {
                return $"{p + q} dollars"; 
            }
            else
            {
                return $"{p + q} dollar";
            }
        }
    }
}
