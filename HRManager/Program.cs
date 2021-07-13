using System;

namespace HRManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmpNum = 1;
            emp.FirstName = "Steve";
            emp.LastName = "Jobs";

            HourlyEmployee hourEmp = new HourlyEmployee();

            hourEmp.EmpNum = 2;
            hourEmp.FirstName = "Bill";
            hourEmp.LastName = "Gates";



            Console.WriteLine("emp.GetPaySummary: " + emp.PaySummary);

            Employee emp2 = hourEmp;
            Console.WriteLine("emp2.GetPaySummary: "+emp2.PaySummary);
            Console.WriteLine(emp2);
            Console.WriteLine("hourEmp.GetPaySummary: " + hourEmp.PaySummary);
        }
    }
}
