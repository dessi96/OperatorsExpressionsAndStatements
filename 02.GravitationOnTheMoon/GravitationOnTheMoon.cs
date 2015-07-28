using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Write("Enter your weight: ");
        double weight = double.Parse(Console.ReadLine());
        double gravField = 0.17;
        
        Console.WriteLine("Your weight on the moon will be: " + (weight * gravField));
    }
}