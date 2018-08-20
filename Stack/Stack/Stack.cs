using System;
using System.Collections.Generic;

namespace MockStack
{
    class Stack
    {
        public List<object> StackList { get; private set; } = new List<object>();

        public void Push(object obj)
        {
            try
            {
                if (obj.Equals(null))
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    StackList.Add(obj);
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Cannot push a null object to the Stack.");
            }
        }

        public object Pop()
        {
            try
            {
                if (StackList.Count == 0)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    var element = StackList[StackList.Count - 1];
                    StackList.RemoveAt(StackList.Count - 1);
                    return element;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Must have an object in the stack to pop.");
                return null;
            }
        }

        public void Clear()
        {
            StackList.Clear();
        }

    }
}
