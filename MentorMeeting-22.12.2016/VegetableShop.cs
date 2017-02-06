using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableShop
{
    class VegetableShop
    {
        static void Main(string[] args)
        {
            double priceVegetables = double.Parse(Console.ReadLine());
            double priceFruits = double.Parse(Console.ReadLine());
            int kilosVegetables = int.Parse(Console.ReadLine());
            int kilosFruits = int.Parse(Console.ReadLine());

            double totalPriceVegetables = priceVegetables * kilosVegetables;
            double totalPriceFruits = priceFruits * kilosFruits;
            double result = (totalPriceFruits + totalPriceVegetables) / 1.94;
            Console.WriteLine(result);
        }
    }
}
