using System;

namespace SumOfEvenDivisors
{
    class SumOfEvenDivisors
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sumDivisors = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0 && j % 2 == 0)
                    {
                        sumDivisors += j;
                    }
                }
            }
            Console.WriteLine(sumDivisors);
        }
    }
}
