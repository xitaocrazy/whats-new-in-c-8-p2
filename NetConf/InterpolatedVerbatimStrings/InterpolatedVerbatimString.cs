using System;

namespace NetConf.InterpolatedVerbatimStrings
{
    public class InterpolatedVerbatimString
    {
        public static void Demo() 
        {
            const string name = "Daniel";
            const int age = 28;
            Console.WriteLine($@"{name} is '{age}' years old and is \married\.");
            Console.WriteLine(@$"{name} is '{age}' years old and is \married\.");
        }
    }
}