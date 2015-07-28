using System;

    class OddOrEvenIntegers
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            bool isEven = num % 2 == 0;

            Console.WriteLine(isEven);
        }
    }

