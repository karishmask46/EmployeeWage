namespace EmployeeWage
{
    class Program

    {
       
        public static void Main(string[]args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            EmpWageComputation employeeWageComputation = new EmpWageComputation(2);
            employeeWageComputation.AddCompany("TATA", 20, 8, 4, 100, 20);
            employeeWageComputation.CalucalteWage("TATA");
            employeeWageComputation.AddCompany("Mahidra", 30, 8, 4, 100, 20);
            employeeWageComputation.CalucalteWage("Mahindra");
            employeeWageComputation.displayArray();
           
            


        }
    }
}


