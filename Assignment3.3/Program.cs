using System;

namespace Assignment3._3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int ch;
            StackException se = new StackException();
            do
            {
                Console.WriteLine("\n1.Push\n2.Pop\n3.Exit");
                Console.WriteLine("\nEnter the operation");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter the value");
                        int data = Convert.ToInt32(Console.ReadLine());
                        se.Push(data);
                        break;
                    case 2:
                        se.Pop();
                        break;
                    case 3: break;
                }
            }
            while (ch != 3);
        }
    }
}

