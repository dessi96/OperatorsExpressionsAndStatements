using System;

    class Rectangles
    {
        static void Main()
        {
            Console.WriteLine("Please enter two numbers: ");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            double perimeter = (2 * num1) + (2 * num2);
            double area = num1 * num2;

            Console.WriteLine("Perimeter = " + perimeter);
            Console.WriteLine("Area = " + area);
        }
    }

