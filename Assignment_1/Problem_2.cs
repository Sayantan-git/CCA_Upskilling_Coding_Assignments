using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Assignment_1
{
    public class Problem_2
    {
        public void Average()
        {
            Console.WriteLine("Enter First student marks: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second student marks: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Third student marks: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Fourth student marks: ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Fifth student marks: ");
            int e = Convert.ToInt32(Console.ReadLine());

            if ((a >= b) && (a >= c) && (a >= d) && (a >= e))
            {
                Console.WriteLine("The highest number is: {0}", a);
                return;
            }
            if ((b >= a) && (b >= c) && (b >= d) && (b >= c))
            {
                Console.WriteLine("The highest number is: {0}", b);
                return;
            }
            if ((c >= a) && (c >= b) && (c >= d) && (c >= e))
            {
                Console.WriteLine("The highest number is: {0}", c);
                return;
            }
            if ((d >= a) && (d >= b) && (d >= c) && (d >= e))
            {
                Console.WriteLine("The highest number is: {0}", d);
                return;
            }
            if ((e >= a) && (e >= b) && (e >= c) && (e >= d))
            {
                Console.WriteLine("The highest number is: {0}", e);
                return;
            }


        }
    }
}
