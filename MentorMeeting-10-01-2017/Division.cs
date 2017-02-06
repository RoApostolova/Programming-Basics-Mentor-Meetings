using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class Division
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double counter1 = 0.0;
            double counter2 = 0.0;
            double counter3 = 0.0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    counter1++;
                }
                if (number % 3 == 0)
                {
                    counter2++;
                }
                if (number % 4 == 0)
                {
                    counter3++;
                }
            }

            Console.WriteLine("{0:F2}%", counter1 / n * 100);
            Console.WriteLine("{0:F2}%", counter2 / n * 100);
            Console.WriteLine("{0:F2}%", counter3 / n * 100);
        }
    }
}
