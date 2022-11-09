using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Problem_1
    {
        public void Calculator()
        {
            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("1 for Addition");
            Console.WriteLine("2 for Subtraction");
            Console.WriteLine("3 for Multiplication");
            Console.WriteLine("4 for Division");

            int action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1st number");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int input2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;


            switch (action)
            {
                case 1:
                    {
                        result = input1 + input2;
                        Console.WriteLine("addition of 2 numbers:" + result);
                        break;
                    }
                case 2:
                    {
                        result = input1 - input2;
                        Console.WriteLine("subtraction of 2 numbers:" + result);
                        break;
                    }
                case 3:
                    {
                        result = input1 * input2;
                        Console.WriteLine("multiplication of 2 numbers:" + result);
                        break;
                    }
                case 4:
                    {
                        result = input1 / input2;
                        Console.WriteLine("division of 2 numbers:" + result);
                        break;
                    }

                default:

                    Console.WriteLine("Wrong action!! try again");
                    break;
            }

            Console.ReadKey();
        }
    }
}
