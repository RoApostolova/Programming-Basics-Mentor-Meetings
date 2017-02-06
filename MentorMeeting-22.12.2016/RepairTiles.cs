using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairTiles
{
    class RepairTiles
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double o = double.Parse(Console.ReadLine());

            double area = n * n;
            double bench = m * o;
            double areaToCover = area - bench;
            double areaTile = w * l;
            double neededTiles = areaToCover / areaTile;
            double timeNeeded = 0.2 * neededTiles;
            Console.WriteLine(neededTiles);
            Console.WriteLine(timeNeeded);

        }
    }
}
