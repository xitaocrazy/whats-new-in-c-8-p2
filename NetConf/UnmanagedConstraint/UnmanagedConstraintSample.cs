using System;
using NetConf.Helpers.Structs;

namespace NetConf.UnmanagedConstraint
{
    public class UnmanagedConstraintSample
    {
        public static void Demo() 
        {
            Console.WriteLine("-----------------------------------");
            DisplayInfo<Measures<int>>();
            DisplayInfo<Measures<double>>();
            CreateSpan();
        }

        private static unsafe void DisplayInfo<T>() where T : unmanaged =>
            Console.WriteLine($"{typeof(T)} is unmanaged with size {sizeof(T)} bytes");
        
        private static void CreateSpan()
        {
            Span<Measures<int>> measures = stackalloc[]
            {
                new Measures<int> {Height = 0, Width = 0, Length = 0},
                new Measures<int> {Height = 10, Width = 10, Length = 10}
            };

            foreach (var measure in measures)
            {
                Console.WriteLine($"Height = {measure.Height}, Width = {measure.Width}, Length = {measure.Length}");
            }
        }
    }
}