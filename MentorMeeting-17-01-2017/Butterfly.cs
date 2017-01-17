using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = 2 * (n - 2) + 1;
            int width = 2 * n - 1;
            int half = n - 1;

            for (int i = 0; i <= height / 2 - 1; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine("{0}\\ /{0}", new string('*', half - 1));
                }
                else
                {
                    Console.WriteLine("{0}\\ /{0}", new string('-', half - 1));
                }
            }

            Console.WriteLine("{0}@{0}",new string(' ',half));

            for (int i = 0; i <= height / 2 - 1; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}/ \\{0}", new string('*', half - 1));
                }
                else
                {
                    Console.WriteLine("{0}/ \\{0}", new string('-', half - 1));
                }
            }
        }
    }
}
