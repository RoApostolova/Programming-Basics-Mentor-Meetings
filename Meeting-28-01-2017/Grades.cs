using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());

            double overFive = 0.0;
            double betweenFourAndFive = 0.0;
            double betweenThreeAndFour = 0.0;
            double fail = 0.0;
            double sumGrades = 0.0;

            for (int i = 0; i < students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                sumGrades += grade;
                if(grade < 3.00)
                {
                    fail++;
                }
                else if(grade < 4.00)
                {
                    betweenThreeAndFour++;
                }
                else if (grade < 5.00)
                {
                    betweenFourAndFive++;
                }
                else 
                {
                    overFive++;
                }
            }
           
            Console.WriteLine("Top students: {0:F2}%",(overFive / students) * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:F2}%", (betweenFourAndFive / students) * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:F2}%", (betweenThreeAndFour / students) * 100);
            Console.WriteLine("Fail: {0:F2}%", (fail / students) * 100);
            Console.WriteLine("Average: {0:F2}",sumGrades / students);
        }
    }
}
