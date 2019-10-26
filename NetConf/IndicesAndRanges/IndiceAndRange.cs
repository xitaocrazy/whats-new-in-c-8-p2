using System.Linq;
using System;

namespace NetConf.IndicesAndRanges
{
    public class IndiceAndRange
    {
        private static string[] racas = {
                            //Indice do início      indice do fim
            "Humano",       //0                     ^9
            "Minotauro",    //1                     ^8
            "Vampiro",      //2                     ^7
            "Anjo",         //3                     ^6
            "Demonio",      //4                     ^5
            "Zumbi",        //5                     ^4 
            "Lobisomem",    //6                     ^3
            "Mumia",        //7                     ^2
            "Grifo"         //8                     ^1
        };

        public static void Demo() {
            Demo1();
            Demo2();
            Demo3();
            Demo4();
            Demo5();
        }

        private static void Demo1() {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Último item");
            Console.WriteLine(racas[^1]);
        }
        private static void Demo2() {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Range de itens");
            var range = racas[^2..^0];
            foreach(var raca in range)
                Console.WriteLine(raca);
        }

        private static void Demo3() {
            var todos = racas[..]; //Todos os elementos
            var primeiros = racas[..5]; //Até
            var ultimos = racas[5..]; //A partir de

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Todos itens");
            foreach(var raca in todos)
                Console.WriteLine(raca);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Primeiros itens");
            foreach(var raca in primeiros)
                Console.WriteLine(raca);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Últimos itens");
            foreach(var raca in ultimos)
                Console.WriteLine(raca);
        }

        private static void Demo4() {
            Index zumbi = 5; 
            Range primeiros = ..5; 

            Console.WriteLine("-----------------------------------");
            Console.WriteLine(racas[zumbi]);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Primeiros itens");
            foreach(var raca in racas[primeiros])
                Console.WriteLine(raca);
        }

        private static void Demo5() {
            int[] sequence = Enumerable.Range(0, 1000).Select(x => (int) (Math.Sqrt(x) * 1000)).ToArray();
            Console.WriteLine("-----------------------------------");

            for (var start = 0; start < sequence.Length; start+=100)
            {
                Range r = start..(start + 10);
                var (min, max, average) = MovingAverage(sequence, r);
                Console.WriteLine($"De {r.Start} até {r.End}:  \tMin:{min} \tMax:{max} \tMédia:{average}");
            }

            for (var start = 0; start < sequence.Length; start+=100)
            {
                Range r = ^(start + 10)..^start;
                var (min, max, average) = MovingAverage(sequence, r);
                Console.WriteLine($"De {r.Start} até {r.End}:  \tMin:{min} \tMax:{max} \tMédia:{average}");
            }

            (int min, int max, double average) MovingAverage(int[] subsequence, Range range) =>
            (
                subsequence[range].Min(),
                subsequence[range].Max(),
                subsequence[range].Average()
            );
        }
    }
}