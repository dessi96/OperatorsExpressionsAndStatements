using System;

    class ExtractBit
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int bitAtPosition = 3;
            int nRightP = n >> bitAtPosition;
            int bit = nRightP & 1;

            Console.WriteLine(bit);
        }
    }

