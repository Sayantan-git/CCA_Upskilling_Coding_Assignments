using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Function_Overloading
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a+b);
            Console.ReadKey();
        }

        public void add(int a, int b, int c)
        {
            Console.WriteLine(a + b +c );
            Console.ReadKey();
        }

        public void add(int a, int b, int c, int d)
        {
            Console.WriteLine(a + b +c +d);
            Console.ReadKey();
        }
    }
}
