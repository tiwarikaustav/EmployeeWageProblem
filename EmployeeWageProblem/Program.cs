using System;

namespace Employee_Wage_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int isPresent = 0;
            isPresent = Attendance();
            if(isPresent != 0)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
            int dailyEmployeeWage = 0;
            if (isPresent == 1)
            {
                dailyEmployeeWage = DailyEmployeeWage();
            }
            Console.WriteLine("Daily Wage of Employee is: {0}", dailyEmployeeWage);
        }
        
        static int Attendance()
        {
            Random randObj = new Random();
            return randObj.Next(0, 2);
        }
        
        static int DailyEmployeeWage()
        {
            int fullDayHour = 8;
            int perHourWage = 20;
            return fullDayHour * perHourWage;
        }
    }
}