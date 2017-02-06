using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Money
    {
        static void Main(string[] args)
        {
            double bitcoins = double.Parse(Console.ReadLine());
            double yoans = double.Parse(Console.ReadLine());
            double inputCommission = double.Parse(Console.ReadLine());

            double bitcoinsInleva = bitcoins * 1168;
            double yoansInDollars = yoans * 0.15;
            double yoansInLeva = yoansInDollars * 1.76;
            double sumWithoutCommission = (bitcoinsInleva + yoansInLeva) / 1.95;
            double commission = sumWithoutCommission / 100 * inputCommission;
            double sum = sumWithoutCommission - commission;
            Console.WriteLine(sum);
        }
    }
}
