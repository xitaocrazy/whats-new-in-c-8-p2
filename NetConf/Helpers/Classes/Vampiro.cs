using System;
using NetConf.Helpers.Interfaces;

namespace NetConf.Helpers.Classes
{
    public class Vampiro : Humano, IVampiro
    {
        private const int Dano = 2000;
        
        public void Hipnotizar()
        {
            Console.WriteLine("Hipnose realizada!");
        }
        
        public void Deconstruct(out int dano)
        {
            dano = Dano;
        }
    }
}