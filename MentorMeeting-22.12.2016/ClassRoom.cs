using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculations
{
    class ClassRoom
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            int desksWidth = (int)(width * 100 - 100) / 70;
            int deskHeight = (int)(height * 100)/ 120;
            int result = (deskHeight * desksWidth) - 3;
            Console.WriteLine(result);
        }
    }
}
