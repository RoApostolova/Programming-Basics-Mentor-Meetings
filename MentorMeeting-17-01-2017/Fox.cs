﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox
{
    class Fox
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 3;
            int heightTopSide = n;
            int numberDashes = width - 4;
            int numberStars = 1;
            for (int i = 0; i < heightTopSide; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}",new string('*',numberStars), new string('-',numberDashes));
                numberDashes -= 2;
                numberStars++;
            }

            int numberEndStars = (width - 4 - n) / 2;
            int numberMiddleStars = n;

            for (int i = 0; i < n / 3; i++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|",new string('*',numberEndStars), new string('*',numberMiddleStars));
                numberMiddleStars -= 2;
                numberEndStars++;

            }
            numberDashes = 1;
            numberStars = width - 4;
            for (int i = 0; i < heightTopSide; i++)
            {
              
                Console.WriteLine("{0}\\{1}/{0}", new string('-', numberDashes), new string('*', numberStars));
                numberDashes++;
                numberStars -= 2;
            }
        }
    }
}
