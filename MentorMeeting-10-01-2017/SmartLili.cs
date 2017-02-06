using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLili
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            decimal priceWashingMachine = decimal.Parse(Console.ReadLine());
            int pricePerOneToy = int.Parse(Console.ReadLine());
            decimal money = 10.0m;
            decimal savings = 0.0m;
            decimal totalSavings = 0.0m;
            for (int i = 1; i <= age; i++)
            {
                if(i % 2 == 0)
                {
                    savings += money;
                    savings -= 1;
                    money += 10.0m;
                 }
                else
                {
                    savings += pricePerOneToy;
                }
            }
            totalSavings = savings;
            if (totalSavings >= priceWashingMachine)
            {
                Console.WriteLine(" Yes! {0:F2}", totalSavings - priceWashingMachine);
            }
            else
            {
                Console.WriteLine(" No! {0:F2}", priceWashingMachine - totalSavings);
            }
        }
    }
}
