using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForExam
{
    class OnTimeForExam
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinutes = int.Parse(Console.ReadLine());

            int exam = examHour * 60 + examMinutes;
            int arrive = arriveHour * 60 + arriveMinutes;
            int difference = arrive - exam;

            if(difference < -30)
            {
                Console.WriteLine("Early");
            }
            else if(difference <= 0)
            {
                Console.WriteLine("On time");
            }
            else
            {
                Console.WriteLine("Late");
            }

            if(difference != 0)
            {
                int hours = Math.Abs(difference / 60);
                int minutes =Math.Abs(difference % 60);
                if(hours > 0)
                {
                    if(minutes < 10)
                    {
                        Console.WriteLine(hours + ":0" + minutes + "hours");
                    }
                    else
                    {
                        Console.WriteLine(hours + ":" + minutes + "hours");
                    }
                }
                else
                {
                    Console.Write(minutes + " minutes");
                  
                }
                if (difference < 0)
                {
                    Console.WriteLine(" before the start");
                }
                else
                {
                    Console.WriteLine(" after the start");
                }
            }
        }
    }
}
