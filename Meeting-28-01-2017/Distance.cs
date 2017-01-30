using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstSpeed = int.Parse(Console.ReadLine());
            int firstTimeMinutes = int.Parse(Console.ReadLine());
            int secondTimeMinutes = int.Parse(Console.ReadLine());
            int thirdTimeMinutes = int.Parse(Console.ReadLine());

            
            double distanceFirst = firstSpeed * firstTimeMinutes / 60.0;
            double speedAfterRaise = firstSpeed + (0.10 * firstSpeed);
            double distaneSecond = speedAfterRaise * secondTimeMinutes / 60.0;
            double distanceThird = (speedAfterRaise - (speedAfterRaise * 0.05)) * thirdTimeMinutes / 60.0;
            double result = distanceFirst + distaneSecond + distanceThird;
            Console.WriteLine("{0:F2}",result);
        }
    }
}
