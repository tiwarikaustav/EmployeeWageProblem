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
            int totalWorkingHours = 0;
            int WORKING_HOUR_LIMIT = 100;
            int count = 0;
            while(count < daysPerMonth && totalWorkingHours <= WORKING_HOUR_LIMIT){
                isPresent = Attendance();                   
                switch (isPresent)
                {
                    case 0:
                        Console.WriteLine("Employee is Absent");
                        count++;
                        break;
                    case 1:
                        Console.WriteLine("Employee is Present but Half Day");
                        totalWorkingHours += 4;
                        count++;
                        dailyEmployeeWage = DailyEmployeeWage(isPresent);
                        wagePerMonth += dailyEmployeeWage;
                        break;
                    case 2:
                        Console.WriteLine("Employee is Present Full Day");
                        totalWorkingHours += 8;
                        count++;
                        dailyEmployeeWage = DailyEmployeeWage(isPresent);
                        wagePerMonth += dailyEmployeeWage;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("Monthly Wage of Employee is: {0}", wagePerMonth);
            Console.WriteLine("Total Working Hours of Employee is: {0}", totalWorkingHours);
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
            else if (halfOrFull == 2)
                return fullDayHour * perHourWage;
            else
                return 0;
        }
    }
}