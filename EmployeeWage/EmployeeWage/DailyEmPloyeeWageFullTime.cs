using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class UC2_DailyEmployeeWageFullTime
    {
        public int EmpPresent = 1;
        public int FullTime = 1;
        public int Wage_per_hour = 20;
        public int Full_day_hour = 8;
        public int PartTime_Day_Hour = 4;
        public int Dailywage = 0;
        public void DailyEmpWage()
        {
            Random Empcheck = new Random();
            int value = Empcheck.Next(0, 2);
            if (value == EmpPresent)
            {
                Random Timecheck = new Random();
                int workingHours = Timecheck.Next(0, 2);
                if (workingHours == FullTime)
                {
                    Dailywage = Wage_per_hour * Full_day_hour;
                    Console.WriteLine("Employee is present  " + Dailywage);


                }
                else
                {
                    Console.WriteLine("Employee is Absent");
                }
            }
        }
    }

}


