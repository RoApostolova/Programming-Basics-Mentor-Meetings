using System;

namespace Rocket
{
    class Rocket
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 3 * n;
            int space = 0;
            int dots = (width - 2 - space) / 2;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}",new string('.',dots), new string(' ', space));
                space += 2;
                dots--;
            }
            Console.WriteLine("{0}{1}{0}",new string('.',n/2),new string('*',width - (2 * n / 2)));
            for (int i = 0; i < n * 2; i++)
            {
                Console.WriteLine("{0}|{1}|{0}",new string('.',n/2), new string('\\', width - (n/2 * 2 + 2)));
            }
            dots = n / 2;
            int asterisks = width - (dots * 2 + 2);
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}",new string('.',dots), new string('*', asterisks));
                dots--;
                asterisks += 2;
            }
        }
    }
}
