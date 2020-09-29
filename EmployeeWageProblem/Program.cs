using System;

namespace Employee_Wage_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int isPresent = 0;
            isPresent = Attendance();
            if (isPresent != 0)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
        static int Attendance()
        {
            Random randObj = new Random();
            return randObj.Next(0, 2);
        }
    }
}