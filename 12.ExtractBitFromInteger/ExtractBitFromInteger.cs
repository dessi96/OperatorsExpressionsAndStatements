using System;

    class ExtractBitFromInteger
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("p = ");
            int bitAtPosition = int.Parse(Console.ReadLine());
            int nRightP = n >> bitAtPosition;
            int bit = nRightP & 1;

            Console.WriteLine(bit);
        }
    }

