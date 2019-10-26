using System;

namespace NetConf.StackAlloc
{
    public class StackAlloc
    {
        public static void Demo() 
        {
            Span<int> numbers = stackalloc[] { 1, 2, 3, 4, 5, 6 };
            var ind = numbers.IndexOfAny(stackalloc[] { 7, 4, 6 ,8 });
            Console.WriteLine(ind);
        }
    }
}