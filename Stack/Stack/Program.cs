using System;

namespace MockStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            //passing 3 different objects
            stack.Push(null);
            stack.Push(2);
            stack.Push("third object");

            Console.WriteLine(stack.Pop()); // should firstly pop the third item
            Console.WriteLine(stack.Pop());
            
            Console.WriteLine(stack.Pop()); // nothing left in the stack to pop. should display a exception message.
        }
    }
}
