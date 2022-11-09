using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Employee
    {
        private int EmpNo { get; set; }
        private string EmpName { get; set; }
        private double Salary { get; set; }
        private double HRA { get; set; }
        private double TA { get; set; }
        private double DA { get; set; }
        private double PF { get; set; }
        private double TDS { get; set; }
        private double NetSalary { get; set; }
        private double GrossSalary { get; set; }


        public void EmployeeDetails()
        {
            Console.WriteLine("Enter your Employee Number: ");
            EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Employee Name: ");
            EmpName = Console.ReadLine();
            Console.WriteLine("Enter your Employee Salary: ");
            Salary = Convert.ToDouble(Console.ReadLine());

            try
            {
                if (Salary <= 0)
                {
                    throw new Exception();
                }
                if (Salary < 5000)
                {
                    HRA = Salary * 10 / 100; TA = Salary * 5 / 100; DA = Salary * 15 / 100;
                }
                else if (Salary > 5000 && Salary < 10000)
                {
                    HRA = Salary * 15 / 100; TA = Salary * 10 / 100; DA = Salary * 20 / 100;


                }
                else if (Salary > 10000 && Salary < 15000)
                {
                    HRA = Salary * 20 / 100; TA = Salary * 15 / 100; DA = Salary * 25 / 100;


                }
                else if (Salary > 15000 && Salary < 20000)
                {
                    HRA = Salary * 25 / 100; TA = Salary * 20 / 100; DA = Salary * 30 / 100;


                }
                else
                {
                    HRA = Salary * 30 / 100; TA = Salary * 25 / 100; DA = Salary * 35 / 100;


                }
                GrossSalary = Salary + HRA + TA + DA;
                CalculateSalary(GrossSalary);

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Salary cannot be zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Give a proper salary ");


            }
        }
        public void CalculateSalary(double GrossSalary)
        {
            PF = GrossSalary * 10 / 100;
            TDS = GrossSalary * 18 / 100;
            NetSalary = GrossSalary - (PF + TDS);
            DisplaySalary(GrossSalary, PF, TDS, NetSalary);


        }
        public void DisplaySalary(double GrossSalary, double PF, double TDS, double NetSalary)
        {
            Console.WriteLine("Gross Salary is " + GrossSalary);
            Console.WriteLine("PF is " + PF);
            Console.WriteLine("TDS is " + TDS);
            Console.WriteLine("NET Salary is " + NetSalary);
        }

    }
}
