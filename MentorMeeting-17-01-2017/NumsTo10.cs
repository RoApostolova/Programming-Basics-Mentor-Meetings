using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNums
{
    class NumsTo10
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string[] nums = { "zero", "one", "two","three","four","five","six","seven","eight","nine" };
            string result = "";
            for (int i = 0; i < 10; i++)
            {
                if(num == i)
                {
                    result = nums[i];
                    Console.WriteLine(result);
                }
               
            }
          if(num > 9 || num < 0)
            {
                Console.WriteLine("number too big");
            }
        }
    }
}
