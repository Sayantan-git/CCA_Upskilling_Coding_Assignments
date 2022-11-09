using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Problem_5
    {
        public void AreaCircumference()
        {
            float r = 9;
            float area = (float)(3.14 * r * r);
            float circumference = (float)(2 * 3.14 * r);

            (float a, float c) = CalculateAreaCircumference(r);

            Console.WriteLine("Area = " + a + " Circumference = " + c);
            Console.ReadKey();
        }

        public (float,float) CalculateAreaCircumference(float radius)
        {
            float area = (float)(3.14 * radius * radius);
            float circumference = (float)(2 * 3.14 * radius);

            return (area, circumference);
        }

    }
}
