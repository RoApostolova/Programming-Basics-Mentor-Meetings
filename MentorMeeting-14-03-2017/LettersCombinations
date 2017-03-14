using System;

namespace LettersCombinations
{
    class LettersCombinations
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char letterToSkip = char.Parse(Console.ReadLine());
            int counter = 0;

            for (char i = start; i <= end; i++)
            {
                for (char j = start; j <= end; j++)
                {
                    for (char k = start; k <= end; k++)
                    {
                        if (i == letterToSkip || j == letterToSkip || k == letterToSkip)
                        {
                            continue;
                        }
                        counter++;
                        Console.Write("{0}{1}{2} ", i, j, k);
                    }
                }

            }
            Console.WriteLine(counter);
        }
    }
}
