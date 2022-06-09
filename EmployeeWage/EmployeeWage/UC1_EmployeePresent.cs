using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class UC1_EmployeePresent
    {
        public int EmpPresent = 1;
        public void CheckEmpPresentAbsent()
        {
            Random Empcheck = new Random();
            int value = Empcheck.Next(0, 2);
            if (value == EmpPresent)
            {
                Console.WriteLine("Employee is present");

            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
