using System;
using System.Collections.Generic;

namespace NetConf.NullCoalescingAssignment
{
    public class NullCoalescingAssignmentSample
    {
        public static void Demo() 
        {
            List<int> numbers = null;
            int? i = null;

            numbers ??= new List<int>();
            numbers.Add(i ??= 3);
            numbers.Add(i ??= 23);

            Console.WriteLine(string.Join(" - ", numbers));
            Console.WriteLine(i);
        }
    }
}