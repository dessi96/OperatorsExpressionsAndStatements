using System;

class Voleyball
    {
        static void Main()
        {
            string leap = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekendsHometown = int.Parse(Console.ReadLine());

            int weekendsInYear = 48;
            int normalWeekends = weekendsInYear - weekendsHometown;
            double games = weekendsHometown * 1.0 + normalWeekends * 3.0 / 4.0 + holidays * 2.0 / 3.0;

            if (leap == "leap")
            {
                games = games * 1.15;
            }
            Console.WriteLine((int)games);
        }
    }

