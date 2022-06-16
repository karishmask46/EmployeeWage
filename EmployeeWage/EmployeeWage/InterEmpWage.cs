using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal interface InterEmpWage
    {
        public void AddCompany(string CompanyName, int EmpWagePerHour, int Full_Time_WorkingHrs_perDay, int Part_Time_WorkingHrs_perDay, int MAX_WORKING_HRS, int MAX_WORKING_DAYS);
        public void CalucalteWage(string CompanyName);
    }
}
