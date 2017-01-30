using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace _3_z
{
    class Program
    {
        static void Main(string[] args)
        {
            int chrys = int.Parse(Console.ReadLine());
            int rose = int.Parse(Console.ReadLine());
            int tullip = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();
            int sumOfFlowers = chrys + rose + tullip;
            double priceForAll = 0;
            if (season == "Spring" || season == "Summer")
            {
                priceForAll = chrys * 2.0 + rose * 4.10 + tullip * 2.50;
 
            }
            else if (season == "Winter" || season == "Autumn")
            {
                priceForAll = chrys * 3.75 + rose * 4.50 + tullip * 4.15;
            }
            if (holiday == "Y")
            {
                priceForAll += priceForAll * 0.15;
            }
            if (season == "Spring" && tullip > 7)
            {
                priceForAll -= priceForAll * 0.05;
            }
            if (season == "Winter" && rose >= 10)
            {
                priceForAll -= priceForAll * 0.1;
            }
            if (sumOfFlowers > 20)
            {
                priceForAll -= priceForAll * 0.2;
            }
            Console.WriteLine("{0:f2}", priceForAll + 2);
        }
    }
}
