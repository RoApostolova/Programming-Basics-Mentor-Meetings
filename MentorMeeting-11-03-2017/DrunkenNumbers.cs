using System;

namespace DrunkenNumbers
{
    class DrunkenNumbers
    {
        static void Main()
        {
            int numberRounds = int.Parse(Console.ReadLine());

            int vladkoBeers = 0;
            int mitkoBeers = 0;

            for (int i = 0; i < numberRounds; i++)
            {
                int drunkenNumber = int.Parse(Console.ReadLine());

                int numberDigits = 0;
                int currentNumber = drunkenNumber;
                while (currentNumber != 0)
                {
                    currentNumber = currentNumber / 10;
                    numberDigits++;
                }
                //right part
                for (int r = 0; r < numberDigits / 2; r++)
                {
                    int currentDigit = drunkenNumber % 10;
                    drunkenNumber = drunkenNumber / 10;
                    vladkoBeers += currentDigit;
                }
                if (numberDigits % 2 != 0)
                {
                    int middleDigit = drunkenNumber % 10;
                    mitkoBeers += middleDigit;
                    vladkoBeers += middleDigit;
                    drunkenNumber = drunkenNumber / 10;
                }
                //left part
                for (int l = 0; l < numberDigits / 2; l++)
                {
                    int currentDigit = drunkenNumber % 10;
                    drunkenNumber = drunkenNumber / 10;
                    mitkoBeers += currentDigit;
                }
            }

            if (mitkoBeers == vladkoBeers)
            {
                Console.WriteLine("No {0}", vladkoBeers + mitkoBeers);
            }
            else if (mitkoBeers < vladkoBeers)
            {
                Console.WriteLine("V {0}", vladkoBeers - mitkoBeers);
            }
            else
            {
                Console.WriteLine("M {0}", mitkoBeers - vladkoBeers);
            }
        }
    }
}

