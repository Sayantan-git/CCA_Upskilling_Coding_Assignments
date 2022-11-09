using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Prime
    {
        public void checkPrime()
        {
            Console.WriteLine("Enter a number : ");
            int a = int.Parse(Console.ReadLine());
            int flag = 0;
            for(int i = 2; i <= a/2; i++)
            {
                if (a % i == 0)
                {
                    flag = 1;
                    break;
                }
                    
            }

            if(flag == 0)
                Console.WriteLine("The number is prime");
            else
                Console.WriteLine("The number is not prime");

            Console.ReadKey();

        }
    }
}
