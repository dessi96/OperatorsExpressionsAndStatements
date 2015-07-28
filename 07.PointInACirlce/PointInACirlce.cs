using System;

    class PointInACirlce
    {
        static void Main()
        {
            Console.Write("Enter a number x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter a number y: ");
            double y = double.Parse(Console.ReadLine());

            bool inACircle = (x * x) + (y * y) <= (2 * 2);
            Console.WriteLine(inACircle);
        }
    }
