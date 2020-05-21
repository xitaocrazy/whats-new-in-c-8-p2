using System;
using System.Collections.Generic;

namespace NetConf.StaticLocalFunctions
{
    public class StaticLocalFunction
    {
        public static void Demo() 
        {
            foreach (var i in IterateFromTo(1,10))
                Console.WriteLine(i);
        }

        private static IEnumerable<int> IterateFromTo(int start, int end)
        {
            if (start >= end)
                throw new ArgumentOutOfRangeException(null,"The beginning must be less than the end.");

            return IterateFromToLocally(start, end);

            static IEnumerable<int> IterateFromToLocally(int localStart, int localEnd) 
            {
                for (var i = localStart; i <= localEnd; i++)
                    yield return i;
            }
        }
    }
}