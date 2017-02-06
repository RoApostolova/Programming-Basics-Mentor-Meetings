using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_6_03
{
    class TransportPrice
    {
        static void Main(string[] args)
        {
            int kilometers = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            decimal taxiDayPrice = 0.7m + kilometers * 0.79m;
            decimal taxiNightPrice = 0.7m + kilometers * 0.90m;
            decimal busPrice = kilometers * 0.09m;
            decimal trainPrice = kilometers * 0.06m;

            if(kilometers < 20)
            {
                if(dayOrNight == "day")
                {
                    Console.WriteLine(taxiDayPrice);
                }
                else
                {
                    Console.WriteLine(taxiNightPrice);
                }
            }
            else if (kilometers < 100)
            {
                Console.WriteLine(busPrice);
            }
            else
            {
                Console.WriteLine(trainPrice);
            }
        }
    }
}
