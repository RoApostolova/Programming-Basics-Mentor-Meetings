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
            decimal savings = decimal.Parse(Console.ReadLine());
            decimal widthFloor = decimal.Parse(Console.ReadLine());
            decimal lengthFloor = decimal.Parse(Console.ReadLine());
            decimal sideTriangle = decimal.Parse(Console.ReadLine());
            decimal heightTriangle = decimal.Parse(Console.ReadLine());
            decimal priceOneTile = decimal.Parse(Console.ReadLine());
            decimal moneyForWorkMan = decimal.Parse(Console.ReadLine());

            decimal floorArea = widthFloor * lengthFloor;
            decimal tileArea = sideTriangle * heightTriangle / 2m;
            decimal neededTiles = Math.Ceiling(floorArea / tileArea) + 5m;
            decimal spendedMoney = neededTiles * priceOneTile + moneyForWorkMan;

            if(savings >= spendedMoney)
            {
                Console.WriteLine("{0:F2} lv left.",savings - spendedMoney);
            }
            else
            {
                Console.WriteLine("You'll need {0:F2} lv more.",spendedMoney - savings);
            }
        }
    }
}
