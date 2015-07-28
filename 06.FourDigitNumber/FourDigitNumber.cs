using System;

    class FourDigitNumber
    {
        static void Main()
        {
            Console.Write("Enter a four-digit number: ");
            int num = int.Parse(Console.ReadLine());

            int firstDigit = num % 10;
            int restTwo = num / 10;
            int secondDigit = restTwo % 10;
            int restThree = num / 100;
            int thirdDigit = restThree % 10;
            int restFour = num / 1000;
            int fourthDigit = restFour % 10;

            Console.WriteLine("Sum of digits: " + (firstDigit + secondDigit + thirdDigit + fourthDigit));
            Console.WriteLine("Number in reversed order: " + firstDigit + secondDigit + thirdDigit + fourthDigit);
            Console.WriteLine("Last digit in first position: " + firstDigit  + fourthDigit + thirdDigit + secondDigit);
            Console.WriteLine("Second and third digits exchanged: " + fourthDigit + secondDigit + thirdDigit +firstDigit);
        }
    }
