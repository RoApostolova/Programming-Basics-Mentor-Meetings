using System;

namespace Hospital
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int numberOfDoctors = 7;
            int untreated = 0;
            int treated = 0;


            for (int i = 1; i <= days; i++)
            {
                int numberOfPatients = int.Parse(Console.ReadLine());


                if (i % 3 == 0)
                {
                    if (untreated > treated)
                    {
                        numberOfDoctors++;
                    }
                }

                if (numberOfPatients > numberOfDoctors)
                {
                    treated += numberOfDoctors;
                    untreated += (numberOfPatients - numberOfDoctors);
                }
                else
                {
                    treated += numberOfPatients;
                  
                }

            }
            Console.WriteLine("Treated patients: {0}.", treated);
            Console.WriteLine("Untreated patients: {0}.", untreated);
        }
    }
}
