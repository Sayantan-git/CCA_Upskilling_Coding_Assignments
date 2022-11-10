using System;
using System.Collections;
namespace Assignment3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack myStack = new MyStack();

            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            myStack.PrintStack();
            Console.WriteLine("Do you want to clone the stack - y/n: ");
            char action = Console.ReadKey().KeyChar;
            MyStack myStack_copy;
            switch (action)
            {
                case 'y':
                    {
                        myStack_copy = myStack;
                        Console.WriteLine("New Copied Stack is: ");
                        myStack_copy.PrintStack();
                        Console.WriteLine();
                        break;
                    }
                case 'n':
                    {
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Incorrect choice!!");
                        break;   
                    }
            }
            myStack.Peek();
            Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());
            myStack.PrintStack();
        }
    }
}
