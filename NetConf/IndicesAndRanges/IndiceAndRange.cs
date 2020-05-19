using System.Linq;
using System;

namespace NetConf.IndicesAndRanges
{
    public class IndiceAndRange
    {
        private static readonly string[] Races = {
                            //Start Index        End Index
            "Human",        //0                     ^9
            "Minotaur",     //1                     ^8
            "Vampire",      //2                     ^7
            "Angel",        //3                     ^6
            "Demon",        //4                     ^5
            "Zombie",       //5                     ^4 
            "Werewolf",     //6                     ^3
            "Mummy",        //7                     ^2
            "Griffin"       //8                     ^1
        };

        public static void Demo() {
            ShowLasItem();
            ShowRange();
            ShowAllItems();
            ShowFirstItems();
            ShowLastItems();
            ShowUsingVars();
            ShowFristTenEachHundred();
            ShowLastTenEachHundred();
        }

        private static void ShowLasItem() {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Last item using index range");
            Console.WriteLine(Races[^1]);
            Console.WriteLine("Last item without using index range");
            Console.WriteLine(Races[Races.Length-1]);
        }
        
        private static void ShowRange() {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Show three before last using index range");
            var range = Races[^4..^1];
            foreach(var race in range)
                Console.WriteLine(race);
            Console.WriteLine("Show three before last without using index range");
            range = new[]
            {
                Races[Races.Length - 4],
                Races[Races.Length - 3],
                Races[Races.Length - 2]
            };
            foreach(var race in range)
                Console.WriteLine(race);
        }

        private static void ShowAllItems() {
            var all = Races[..];
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("All items using index range");
            foreach(var race in all)
                Console.WriteLine(race);
        }

        private static void ShowFirstItems()
        {
            var first = Races[..5]; 
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("First items using index range");
            foreach (var race in first)
                Console.WriteLine(race);
            Console.WriteLine("First items without using index range");
            for (var i=0; i<5; i++)
                Console.WriteLine(Races[i]);
        }

        private static void ShowLastItems()
        {
            var last = Races[5..];
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Last items using index range");
            foreach (var raca in last)
                Console.WriteLine(raca);
            Console.WriteLine("Last items without using index range");
            for (var i=Races.Length-4; i<Races.Length; i++)
                Console.WriteLine(Races[i]);
        }

        private static void ShowUsingVars() {
            Index zumbi = 5; 
            var primeiros = ..5; 

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Show one using var");
            Console.WriteLine(Races[zumbi]);
            Console.WriteLine("Show range using var");
            foreach(var race in Races[primeiros])
                Console.WriteLine(race);
        }

        private static void ShowFristTenEachHundred()
        {
            var sequence = Enumerable.Range(0, 1000).Select(x => (int) (Math.Sqrt(x) * 1000)).ToArray();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Show first 10 each 100");
            for (var start = 0; start < sequence.Length; start += 100)
            {
                var r = start..(start + 10);
                var (min, max, average) = MovingAverage(sequence, r);
                Console.WriteLine($"From {r.Start.ToString().PadRight(12)} to {r.End.ToString().PadRight(12)}:  \tMin:{min.ToString().PadRight(12)} \tMax:{max.ToString().PadRight(12)} \tAverage:{average.ToString().PadRight(12)}");
            }
        }

        private static void ShowLastTenEachHundred()
        {
            var sequence = Enumerable.Range(0, 1000).Select(x => (int) (Math.Sqrt(x) * 1000)).ToArray();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Show last 10 each 100");
            for (var start = 0; start < sequence.Length; start += 100)
            {
                var r = ^(start + 10)..^start;
                var (min, max, average) = MovingAverage(sequence, r);
                Console.WriteLine($"From {r.Start.ToString().PadRight(12)} to {r.End.ToString().PadRight(12)}:  \tMin:{min.ToString().PadRight(12)} \tMax:{max.ToString().PadRight(12)} \tAverage:{average.ToString().PadRight(12)}");
            }
        }

        private static (int min, int max, double average) MovingAverage(int[] subsequence, Range range) => (subsequence[range].Min(), subsequence[range].Max(), subsequence[range].Average());
    }
}