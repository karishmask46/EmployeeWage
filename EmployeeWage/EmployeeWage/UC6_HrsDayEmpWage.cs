using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class UC6HrsDayEmpWage
    {
        public const float EmpWagePerHour = 20;
        public const int FullTime_WorkingHrs_PerDay = 8;
        public const int PartTime_WorkingHrs_PerDay = 4;
        public const int MAX_WORKING_HRS = 100;
        public const int MAX_WORKING_DAYS = 20;
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int IS_ABSENT = 0;
        float EmpDailyWage = 0;
        public float TotalWage = 0;
        public int IsEmployeePresent()
        {
            return new Random().Next() % 3;
        }
        public void CalucalteWage()
        {
            int Daynumber = 1;
            int EmpworkingHrs = 0;
            int TotalWorkingHrs = 0;
            while (Daynumber <= MAX_WORKING_DAYS && TotalWorkingHrs <= MAX_WORKING_HRS)
            {
                switch (IsEmployeePresent())
                {
                    case IS_ABSENT:
                        EmpworkingHrs = 0;
                        break;
                    case IS_PART_TIME:
                        EmpworkingHrs = PartTime_WorkingHrs_PerDay;
                        break;
                    case IS_FULL_TIME:
                        EmpworkingHrs = FullTime_WorkingHrs_PerDay;
                        break;
                }
                EmpDailyWage = EmpworkingHrs * EmpWagePerHour;

                TotalWage += EmpDailyWage;
                Daynumber++;
                TotalWorkingHrs += EmpworkingHrs;


            }
            Console.WriteLine("Total Working days : " + (Daynumber) + "\nTotal Working hours : " + (TotalWorkingHrs) + "\nTotal Wage :" + (TotalWage));
        }
    }
}
