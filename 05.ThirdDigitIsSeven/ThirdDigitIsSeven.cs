using System;

    class ThirdDigitIsSeven
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            double num2 = num / 100;
            double num3 = num2 % 10;
            if (num3 == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }

