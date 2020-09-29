using System;

namespace Employee_Wage_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int isPresent = 0;
            isPresent = Attendance();
            int dailyEmployeeWage = 0;
            switch (isPresent)
            {
                case 0:
                    Console.WriteLine("Employee is Absent");
                    break;
                case 1:
                    Console.WriteLine("Employee is Present but Half Day");
                    dailyEmployeeWage = DailyEmployeeWage(isPresent);
                    break;
                case 2:
                    Console.WriteLine("Employee is Present Full Day");
                    dailyEmployeeWage = DailyEmployeeWage(isPresent);
                    break;
                default:
                    break;
            }

            Console.WriteLine("Daily Wage of Employee is: {0}", dailyEmployeeWage);
        }

        /// <summary>
        /// Attendances function returns 0/1/2 randomly
        /// </summary>
        /// <returns></returns>
        static int Attendance()
        {
            Random randObj = new Random();
            return randObj.Next(0, 3);
        }
        /// <summary>
        /// returns daily employee wage as per half time/full time 
        /// </summary>
        /// <param name="halfOrFull">The half or full.</param>
        /// <returns></returns>
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