using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Problem_3
    {
        public void SumOfElementsInArray()
        {
            int[] a = new int[100];

            Console.WriteLine("Input the number of elements to be stored in the array :");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input {0} elements in the array :\n", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += a[i];
            }

            Console.WriteLine("Sum of all elements in array is: " + sum);

        }  
    }
}
