using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyEarnings
{
    class DailyEarnings
    {
        static void Main(string[] args)
        {
            int workingDaysInMonth = int.Parse(Console.ReadLine());
            double dailyEarnings = double.Parse(Console.ReadLine());
            double usdToBgn = double.Parse(Console.ReadLine());

            double monthlySalary = workingDaysInMonth * dailyEarnings;
            double annualSalaryWithTaxes = monthlySalary * 12 + monthlySalary * 2.5;
            double taxes = annualSalaryWithTaxes * 0.25;
            double annualSalaryUsd = annualSalaryWithTaxes - taxes;
            double annualSalaryBgn = annualSalaryUsd * usdToBgn;
            double averageDailySalary = annualSalaryBgn / 365;

            Console.WriteLine("{0:F2}", averageDailySalary);

        }
    }
}
