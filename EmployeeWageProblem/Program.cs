using System;

namespace Employee_Wage_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int isPresent = 0;
            int dailyEmployeeWage = 0;
            int wagePerMonth = 0;
            int daysPerMonth = 20;
            for(int i=0; i<daysPerMonth; i++){
                isPresent = Attendance();
                switch (isPresent)
                {
                    case 0:
                        Console.WriteLine("Employee is Absent");
                        break;
                    case 1:
                        Console.WriteLine("Employee is Present but Half Day");
                        dailyEmployeeWage = DailyEmployeeWage(isPresent);
                        wagePerMonth += dailyEmployeeWage;
                        break;
                    case 2:
                        Console.WriteLine("Employee is Present Full Day");
                        dailyEmployeeWage = DailyEmployeeWage(isPresent);
                        wagePerMonth += dailyEmployeeWage;
                        break;
                    default:
                        daysPerMonth--;
                        break;
                }
            }
            Console.WriteLine("Monthly Wage of Employee is: {0}", wagePerMonth);
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