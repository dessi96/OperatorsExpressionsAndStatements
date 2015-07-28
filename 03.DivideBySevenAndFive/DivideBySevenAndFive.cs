using System;

    class DivideBySevenAndFive
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            bool divideNum = num % 7 == 0 && num % 5 == 0;
            Console.WriteLine(divideNum);
        }
    }

