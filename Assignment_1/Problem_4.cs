using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Problem_4
    {
        public void Swap()
        {
            Console.WriteLine("Enter First Number ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number ");
            int b = Convert.ToInt32(Console.ReadLine());

            (a, b) = (b, a);

            Console.WriteLine("Swapped numbers are " + a + " and " + b);

            Console.ReadKey();
        }


    }
}
