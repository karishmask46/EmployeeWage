using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Company
    {
        public float EmpWagePerHour;
        public int Full_Time_WorkingHrs_perDay;
        public int Part_Time_WorkingHrs_perDay;
        public int MAX_WORKING_HRS;
        public int MAX_WORKING_DAYS;


        public string CompanyName;
        public Company( string CompanyName, int EmpWagePerHour, int Full_Time_WorkingHrs_perDay, int Part_Time_WorkingHrs_perDay, int MAX_WORKING_HRS, int MAX_WORKING_DAYS)
        {
            this.CompanyName = CompanyName;
            this.EmpWagePerHour = EmpWagePerHour;
            this.Full_Time_WorkingHrs_perDay = Full_Time_WorkingHrs_perDay;
            this.Part_Time_WorkingHrs_perDay = Part_Time_WorkingHrs_perDay;
            this.MAX_WORKING_HRS = MAX_WORKING_HRS;
            this. MAX_WORKING_DAYS = MAX_WORKING_DAYS;
           
        }
    }
}
