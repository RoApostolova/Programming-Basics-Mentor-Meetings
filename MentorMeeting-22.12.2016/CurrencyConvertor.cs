using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConvertor
{
    class CurrencyConvertor
    {
        static void Main(string[] args)
        {
            double amountToChange = double.Parse(Console.ReadLine());
            string inputCurrency = Console.ReadLine();
            string outputCurrency = Console.ReadLine();

            double firstRate = 0.0;
            double secondRate = 0.0;

            if(inputCurrency == "BGN")
            {
                firstRate = 1.0;
            }
            else if (inputCurrency == "USD")
            {
                firstRate = 1.79549;
            }
            else if (inputCurrency == "EUR")
            {
                firstRate = 1.95583;
            }
            else if (inputCurrency == "GBP")
            {
                firstRate = 2.53405;
            }


            if (outputCurrency == "BGN")
            {
                secondRate = 1.0;
            }
            else if (outputCurrency == "USD")
            {
                secondRate = 1.79549;
            }
            else if (outputCurrency == "EUR")
            {
                secondRate = 1.95583;
            }
            else if (outputCurrency == "GBP")
            {
                secondRate = 2.53405;
            }

            double result = amountToChange * (firstRate / secondRate);
            Console.WriteLine("{0:F2} {1}",result, outputCurrency);
        }
    }
}
