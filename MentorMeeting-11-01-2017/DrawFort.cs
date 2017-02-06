
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFort
{
    class DrawFort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n;
            int height = n;
            int symbol = n / 2;
            int dashes = width - (symbol * 2) - 4;

            Console.WriteLine("/{0}\\{1}/{0}\\",new string('^',symbol),new string('_',dashes));

            for (int i = 0; i < height - 3; i++)
            {
                Console.WriteLine("|{0}|",new string(' ',width - 2));
            }

            Console.WriteLine("|{0}{1}{0}|",new string(' ',symbol + 1),new string('_',dashes));
            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', symbol), new string(' ', dashes));
        }
    }
}
