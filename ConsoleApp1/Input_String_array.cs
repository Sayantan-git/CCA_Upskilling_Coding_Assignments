using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Input_String_array
    {
        public void string_input_function()
        {
            string[] arr = new string[10];
            int i;
            Console.Write("Enter 10 Strings");


            Console.Write("Input 10 elements in the array :\n");
            for (i = 0; i < 10; i++)
            {
                arr[i] = Console.ReadLine();
            }

            Console.Write("\nElements in array are: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n");

            Console.ReadKey();
        }
        
    }
}
