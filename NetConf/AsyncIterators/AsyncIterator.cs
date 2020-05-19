using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetConf.AsyncIterators
{
    public class AsyncIterator
    {
        public static async Task Demo()
        {
            Console.WriteLine("Sync iterator");
            foreach (var number in GetSequenceUsingEnumerable())
                Console.WriteLine($"Time: {DateTime.Now:hh:mm:ss}. Item: {number}");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Async iterator");
            await foreach (var number in GetSequenceUsingAsyncEnumerable())
                Console.WriteLine($"Time: {DateTime.Now:hh:mm:ss}. Item: {number}");
        }
        
        private static IEnumerable<int> GetSequenceUsingEnumerable()
        {
            var items = new List<int>();
            for (var i = 0; i < 50; i++)
            {
                //every 10 elements awaits 2s
                if (i % 10 == 0)
                {
                    Console.WriteLine($"Processed block.");
                    Task.Delay(2000);
                }
                items.Add(i);
            }
            return items;
        }

        private static async IAsyncEnumerable<int> GetSequenceUsingAsyncEnumerable()
        {
            for (var i = 0; i < 50; i++)
            {
                //every 10 elements awaits 2s
                if (i % 10 == 0)
                {
                    Console.WriteLine($"Processed block.");
                    await Task.Delay(2000);
                }
                yield return i;
            }
        }
    }
}
