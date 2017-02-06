using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal heritage = decimal.Parse(Console.ReadLine());
            int targetYear = int.Parse(Console.ReadLine());

            for (int i = 1800; i <= targetYear; i++)
            {
                if(i % 2 == 0)
                {
                    heritage -= 12000m;
                }
                else
                {
                    heritage -= (12000 + 50 * ((i - 1800) + 18));
                }
            }

            if(heritage >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.",heritage);
            }
            else
            {
                Console.WriteLine("He will need {0:F2} dollars to survive. ",Math.Abs(heritage));
            }
        }
    }
}
