using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmpWageComputation
    {  
        public const int EmpWagePerHour = 20;
        public const int Full_Time_WorkingHrs_PerDay = 8;
        public const int Part_Time_WorkingHrs_PerDay = 4;
        public const int MAX_WORKING_HRS = 100;
        public const int MAX_WORKING_DAYS = 20;
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int IS_ABSENT = 0;
        float EmpDailyWage = 0;
        private float TotalWage = 0;
        public string CompanyName;
       
        

                  
       private Dictionary<string, Company> Companies = new Dictionary<string, Company>();
        public string[] Companylist;
        public int Arrayindex = 0;
        public EmpWageComputation(int number)
        {
            Companylist = new string[2 * number];
        }

       public void AddCompany(string CompanyName, int EmpWagePerHour, int Full_Time_WorkingHrs_PerDay, int Part_Time_WorkingHrs_PerDay, int MAX_WORKING_HRS, int MAX_WORKING_DAYS)
        {
            Company company = new Company(CompanyName.ToLower(), EmpWagePerHour, Full_Time_WorkingHrs_PerDay, Part_Time_WorkingHrs_PerDay, MAX_WORKING_HRS, MAX_WORKING_DAYS);
            Companies.Add(CompanyName.ToLower(), company);
            Companylist[Arrayindex] = CompanyName;
            Arrayindex++;


        }
        public  int IsEmployeePresent()
        {
            return new Random().Next() % 3;
        }
        public void CalucalteWage(string CompanyName)
        {
            
            int Daynumber = 1;
            int EmpworkingHrs = 0;
            int TotalWorkingHrs = 0;

            if (!Companies.ContainsKey(CompanyName.ToLower()))         
            throw new ArgumentNullException("company doesn't Exist");           
            Companies.TryGetValue(CompanyName.ToLower(), out Company company);
            while (Daynumber <= MAX_WORKING_DAYS && TotalWorkingHrs <= MAX_WORKING_HRS)
            {
                switch (IsEmployeePresent())
                {
                    case IS_ABSENT:
                        EmpworkingHrs = 0;
                        break;
                    case IS_PART_TIME:
                        EmpworkingHrs = Part_Time_WorkingHrs_PerDay;
                        break;
                    case IS_FULL_TIME:
                        EmpworkingHrs = Full_Time_WorkingHrs_PerDay;
                        break;
                }
                EmpDailyWage = EmpworkingHrs * EmpWagePerHour;

                TotalWage += EmpDailyWage;
                Daynumber++;
                TotalWorkingHrs += EmpworkingHrs;


            }
            Companylist[Arrayindex] = Convert.ToString(TotalWorkingHrs);
            Arrayindex++;

            Console.WriteLine("Total Working days : " + MAX_WORKING_DAYS + "\nTotal Working hours : " + (TotalWorkingHrs) + "\nTotal Wage :" + (TotalWage));
        }
        public void displayArray()
        {
            for (int i = 0; i < Companylist.Length; i +=2)
            {
                Console.WriteLine("Monthly Wage for {0} is {1}",Companylist[i], Companylist[i+1]);
            }
        }
    }
}
