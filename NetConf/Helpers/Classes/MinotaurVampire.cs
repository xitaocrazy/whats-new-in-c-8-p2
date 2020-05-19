using System;
using NetConf.Helpers.Interfaces;

namespace NetConf.Helpers.Classes 
{
    public class MinotaurVampire : IMinotaurVampire
    {
        public int Age { get; set; }

        public void StrikeWithHorn() => Console.WriteLine("Horn hit: 200");

        public void Hypnotize() => Console.WriteLine("You are mine: 20s");
    }
}