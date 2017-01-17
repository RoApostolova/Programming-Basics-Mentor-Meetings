using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double metric = double.Parse(Console.ReadLine());
            string firstMetric = Console.ReadLine().ToLower();
            string secondMetric = Console.ReadLine().ToLower();
           

            if (firstMetric == "m" )
            {
                metric = metric / 1.0;
            }
            else if (firstMetric == "mm")
            {
                metric = metric / 1000;
            }
            else if (firstMetric == "cm")
            {
                metric = metric / 100;
            }
            else if (firstMetric == "mi")
            {
              metric = metric / 0.000621371192;
            }
            else if (firstMetric == "in")
            {
                metric = metric / 39.3700787;
            }
            else if (firstMetric == "km")
            {
                metric = metric / 0.001;
            }
            else if (firstMetric == "ft")
            {
                metric = metric / 3.2808399;
            }
            else if (firstMetric == "yd")
            {
                metric = metric / 1.0936133;
            }
            if (secondMetric == "m")
            {
               metric = metric * 1.0;
            }
            else if (secondMetric == "mm")
            {
                metric = metric * 1000;
            }
            else if (secondMetric == "cm")
            {
                metric = metric * 100;
            }
            else if (secondMetric == "mi")
            {
               metric = metric * 0.000621371192;
            }
            else if (secondMetric == "in")
            {
                metric = metric * 39.3700787;
            }
            else if (secondMetric == "km")
            {
                metric = metric * 0.001;
            }
            else if (secondMetric == "ft")
            {
                metric = metric * 3.2808399;
            }
            else if (secondMetric == "yd")
            {
                metric = metric * 1.0936133;
            }
           
            Console.WriteLine(metric + " " + secondMetric );
        }
    }
}
