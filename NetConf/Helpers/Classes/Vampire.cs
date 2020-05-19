using System;
using NetConf.Helpers.Interfaces;

namespace NetConf.Helpers.Classes
{
    public class Vampire : Human, IVampire
    {
        private const int Dano = 2000;
        
        public void Hypnotize() => Console.WriteLine("You are mine: 10s");
        
        public void Deconstruct(out int idade) => idade = Age;
    }
}