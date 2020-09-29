using System;

namespace Employee_Wage_Problem
{
    class Program
    {
        class Program
        {
            //commenting
            static void Main(string[] args)
            {
                int isPresent = Attendance();
                if (isPresent == 0)
                    Console.WriteLine("Employee is Absent!");
                else
                    Console.WriteLine("Employee is Present!");
            }

            static int Attendance()
            {
                Random randObj = new Random();
                return randObj.Next(0, 2);
            }
        }
    }
}