﻿using System;

    class PointInsideCircleOutsideRectangle
    {
        static void Main()
        {
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y = double.Parse(Console.ReadLine());

            bool inCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= (1.5 * 1.5);
            bool outsideRectangle = x > 1 || x < 6 && y > -1 || y < 2;

            if (x == 0 || y == 0)
            {
                Console.WriteLine("no");
            }
            else if (inCircle == true && outsideRectangle == true)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }