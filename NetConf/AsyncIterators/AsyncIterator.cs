using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetConf.AsyncIterators
{
    public class AsyncIterator
    {
        public static async Task Demo()
        {
            await foreach (var number in GerarSequencia())
            {
                Console.WriteLine($"Agora são: {DateTime.Now:hh:mm:ss}. Número: {number}");
            }
        }

        private static async IAsyncEnumerable<int> GerarSequencia()
        {
            for (var i = 0; i < 50; i++)
            {
                // a cada 10 elementos aguarda 2s
                if (i % 10 == 0)
                {
                    Console.WriteLine($"Bloco processado.");
                    await Task.Delay(2000);
                }
                yield return i;
            }
        }
    }
}
