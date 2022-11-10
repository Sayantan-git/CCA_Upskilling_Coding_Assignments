using System;

namespace Assignment_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmployeeDetails();
            Console.ReadKey();

            Manager manager= new Manager();
            manager.EmployeeDetails();
            Console.ReadKey();

            MarketingExcutive marketing_exe = new MarketingExcutive();
            marketing_exe.EmployeeDetails();
            Console.ReadKey();

        }
    }
}
