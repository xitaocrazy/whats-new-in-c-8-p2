using System;
using System.Collections.Generic;
namespace NetConf.NullCoalescingAssignment
{
    public class NullCoalescingAssignment
    {
        public static void Demo() 
        {
            List<int> numeros = null;
            int? i = null;

            numeros ??= new List<int>();
            numeros.Add(i ??= 3);
            numeros.Add(i ??= 23);

            Console.WriteLine(string.Join(" - ", numeros));
            Console.WriteLine(i);
        }
    }
}