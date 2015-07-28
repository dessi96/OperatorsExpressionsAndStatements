using System;

    class ModifyBitAtGivenPosition
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("p = ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("v = ");
            int v = int.Parse(Console.ReadLine());
            
            
            if (v == 0)
            {
                Console.WriteLine(n = n & (~(1 << p)));
            }
            else
            {
                Console.WriteLine(n = n | (1 << p));
            }
        }
    }
