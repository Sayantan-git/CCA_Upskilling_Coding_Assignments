using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{

    public class StackException
    {
        int[] Stack = new int[10];
        int top = 0;

        public void Push(int data)
        {
            try
            {
                if (Size() >= 10)
                {
                    throw new Exception("Stack is Full");
                }
                else
                {
                    Stack[top] = data;
                    top++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }

        }

        public void Pop()
        {
            try
            {
                if (!IsEmpty())
                {
                    Stack[top] = 0;
                    top--;
                }
                else
                {
                    throw new Exception("Stack is empty");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }
        }
        public int Size()
        {
            return top;
        }

        public bool IsEmpty()
        {
            if (Size() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }


    public class stack_custom_exception
    {
        public void stack()
        {
            StackException stk = new StackException();

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Pushing in stack: " + i);
                stk.Push(i);
            }

            Console.WriteLine("Poping from stack ");
            Console.ReadKey();

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("Poping " + i);

                stk.Pop();
            }
        }
    }
}
