using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Employee
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
        protected double GrossSalary { get; set; }


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
                CalculateGrossSalary(Salary, HRA, TA, DA);
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
        public virtual void CalculateGrossSalary(double Salary, double HRA, double TA, double DA)
        {
            GrossSalary = Salary + HRA + TA + DA;
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
    public class Manager : Employee
    {
        public override void CalculateGrossSalary(double Salary, double HRA, double TA, double DA)
        {
            Console.WriteLine("Petrol Allowance is " + (Salary * 8 / 100));
            Console.WriteLine("Food Allowance is " + (Salary * 13 / 100));
            Console.WriteLine("Other Allowance is " + (Salary * 3 / 100));
            GrossSalary = Salary + HRA + TA + DA + (Salary * 8 / 100) + (Salary * 13 / 100) + (Salary * 3 / 100);
        }
    }
    public class MarketingExcutive : Employee
    {
        private double KmTeavled { get; set; }


        private float Km { get; set; }
        public override void CalculateGrossSalary(double Salary, double HRA, double TA, double DA)
        {
            Console.WriteLine("How many km will you travel ");
            Km = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Tour Allowance is" + (Km * 5));
            Console.WriteLine("Telephone Allovance is " + 1000);
            GrossSalary = Salary + HRA + TA + DA + (Km * 5) + 1000;
        }
    }


}