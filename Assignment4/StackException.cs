using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public class StackException : Exception
    {
        public StackException() { }
        public StackException(string message) : base(String.Format(message))
        {
        }

        static int MAX = 5;
        int[] st = new int[MAX];
        int top = -1;
        bool isempty()
        {
            if (top == -1)
                return true;
            else
                return false;
        }
        public void Push(int data)
        {
            try
            {
                if (top > MAX)
                {
                    throw new StackException("Stack Overflow");
                }
                else
                {
                    st[++top] = data;
                    top++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Pop()
        {
            int data;
            try
            {
                if (!isempty())
                {
                    data = st[top];
                    top = top - 1;
                }
                else
                {
                    throw new StackException("Stack Underflow");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Stack Underflow");
            }
        }
    }
}
