using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());
        int nRightP = n >> p;
        int bit = nRightP & 1;
        bool isOne = bit == 1;

        Console.WriteLine(isOne);
    }
}