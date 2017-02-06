using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double counter1 = 0.0;
            double counter2 = 0.0;
            double counter3 = 0.0;
            double counter4 = 0.0;
            double counter5 = 0.0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if(number < 200)
                {
                    counter1++;
                }
                else if(number < 400)
                {
                    counter2++;
                }
                else if (number < 600)
                {
                    counter3++;
                }
                else if (number < 800)
                {
                    counter4++;
                }
                else
                {
                    counter5++;
                }
            }

            double p1 = counter1 / n * 100;
            double p2 = counter2 / n * 100;
            double p3 = counter3 / n * 100;
            double p4 = counter4 / n * 100;
            double p5 = counter5 / n * 100;

            Console.WriteLine("{0:F2}%",p1);
            Console.WriteLine("{0:F2}%", p2);
            Console.WriteLine("{0:F2}%", p3);
            Console.WriteLine("{0:F2}%", p4);
            Console.WriteLine("{0:F2}%", p5);
        }
    }
}
