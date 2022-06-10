using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class UC5MonthlyEmpWage
    {
        public const float EmpWagePerHour = 20;
        public const int FullTime_WorkingHrs_PerDay = 8;
        public const int PartTime_WorkingHrs_PerDay = 4;
        public const int Is_Full_Time = 1;
        public const int Is_Part_Time = 2;
        public const int Is_Absent = 0;
        public const int Num_WorkingDays_PerMonth = 20;
        public float EmpMonthlyWage = 0;
        public float EmpDailyWage = 0;

        public int IsEmployeePresent()
        {
            return new Random().Next() % 3;

        }
        public void CalculateWage()
        {
            int DayNumber = 1;
            int EmpWorkingHrs = 0;
            while (DayNumber <= Num_WorkingDays_PerMonth)
            {
                switch (IsEmployeePresent())
                {
                    case Is_Absent:
                        EmpWorkingHrs = 0;
                        break;
                    case Is_Part_Time:
                        EmpWorkingHrs = PartTime_WorkingHrs_PerDay;
                        break;
                    case Is_Full_Time:
                        EmpWorkingHrs = FullTime_WorkingHrs_PerDay;
                        break;
                }
                EmpDailyWage = EmpWorkingHrs * EmpWagePerHour;
                EmpMonthlyWage += EmpDailyWage;
                DayNumber++;

            }
            Console.WriteLine("Employee Monthly Wage : " + EmpMonthlyWage);

        }
    }
}
