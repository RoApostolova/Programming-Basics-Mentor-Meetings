using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStepsInCoding
{
    class Hello
    {
        static void Main(string[] args)
        { 
            int n = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            int rows = n / 4 - 1;
           // head
            Console.WriteLine(" {0}{1}{0}",symbol,new string(' ',rows));
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(" {0}",new string(symbol,rows + 2));
            }
            // neck 
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine("  {0}", new string(symbol, rows));
            }
            // body upper part
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(" {0}", new string(symbol, rows + 2));
            }
            Console.WriteLine(" {0}   {1}", new string(symbol, rows + 2), new string(symbol, rows + 1));
            // body lower part
            for (int i = 0; i < n / 4 + 1; i++)
            {
                Console.WriteLine("{0}  {1}", new string(symbol, n / 4 + 3), symbol);
            }
            Console.WriteLine("{0} {1}", new string(symbol, n / 4 + 3), new string(symbol, 2));
            Console.WriteLine(" {0}", new string(symbol, n / 4 + 4));
        }
    }
}
