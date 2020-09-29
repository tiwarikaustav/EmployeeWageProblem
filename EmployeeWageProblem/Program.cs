using System;

namespace Employee_Wage_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int isPresent = 0;
            isPresent = Attendance();
            if(isPresent == 0)
                Console.WriteLine("Employee is Absent");
            else if(isPresent == 1)
                Console.WriteLine("Employee is Present Half Time");
            else
                Console.WriteLine("Employee is Present Full Time");
            int dailyEmployeeWage = 0;
            if (isPresent != 0)
            {
                dailyEmployeeWage = DailyEmployeeWage(isPresent);
            }
            Console.WriteLine("Daily Wage of Employee is: {0}", dailyEmployeeWage);
        }
        
        static int Attendance()
        {
            Random randObj = new Random();
            return randObj.Next(0, 3);
        }
        
        static int DailyEmployeeWage(int halfOrFull)
        {
            int fullDayHour = 8;
            int halfDayHour = 4;
            int perHourWage = 20;
            if (halfOrFull == 1)
                return halfDayHour * perHourWage;
            else
                return fullDayHour * perHourWage;
        }
    }
}