namespace EmployeeWage
{
    class Program

    {
       
        public static void Main(string[]args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            EmpWageComputation employeeWageComputation = new EmpWageComputation();
            employeeWageComputation.AddCompany("TATA", 20, 8, 4, 100, 20);
            employeeWageComputation.AddCompany("Mahidra", 30, 8, 4, 100, 20);
            employeeWageComputation.CalucalteWage("tata");
            employeeWageComputation.CalucalteWage("mahindra");
            Console.WriteLine();
            employeeWageComputation.CalucalteWage("Mahindra");


        }
    }
}


