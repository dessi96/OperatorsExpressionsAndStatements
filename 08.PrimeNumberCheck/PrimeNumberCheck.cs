using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int divider = 1;
        bool isPrime = false;
        int count = 0;
        for (divider = 1; divider <= num; divider++)  
        {
            if (num % divider == 0)
            {
                count++;       
            }
        }
        if (count == 2)        
        {
            isPrime = true;
        }
        Console.WriteLine(isPrime);
    }
}